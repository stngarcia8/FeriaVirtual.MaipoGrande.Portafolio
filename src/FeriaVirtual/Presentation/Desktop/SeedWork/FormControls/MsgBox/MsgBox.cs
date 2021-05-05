using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace FeriaVirtual.App.Desktop.SeedWork.FormControls.MsgBox
{
    public static class MsgBox
    {
        public static DialogResult Show
            (IWin32Window owner, String message) =>
            Show(owner, message, "Notification", 211);


        public static DialogResult Show
            (IWin32Window owner, String message, int height) =>
            Show(owner, message, "Notification", height);


        public static DialogResult Show
            (IWin32Window owner, String message, String title) =>
            Show(owner, message, title, MessageBoxButtons.OK, 211);


        public static DialogResult Show(IWin32Window owner, String message, String title, int height) =>
            Show(owner, message, title, MessageBoxButtons.OK, height);


        public static DialogResult Show
            (IWin32Window owner, String message, String title, MessageBoxButtons buttons) =>
            Show(owner, message, title, buttons, MessageBoxIcon.None, 211);


        public static DialogResult Show
            (IWin32Window owner, String message, String title, MessageBoxButtons buttons, int height) =>
            Show(owner, message, title, buttons, MessageBoxIcon.None, height);


        public static DialogResult Show
            (IWin32Window owner, String message, String title, MessageBoxButtons buttons, MessageBoxIcon icon) =>
            Show(owner, message, title, buttons, icon, MessageBoxDefaultButton.Button1, 211);


        public static DialogResult Show
            (IWin32Window owner, String message, String title, MessageBoxButtons buttons, MessageBoxIcon icon, int height) =>
            Show(owner, message, title, buttons, icon, MessageBoxDefaultButton.Button1, height);


        public static DialogResult Show
            (IWin32Window owner, String message, String title, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultbutton) =>
            Show(owner, message, title, buttons, icon, defaultbutton, 211);


        public static DialogResult Show
            (IWin32Window owner, String message, String title,
            MessageBoxButtons buttons, MessageBoxIcon icon,
            MessageBoxDefaultButton defaultButton, int height)
        {
            var _result = DialogResult.None;
            if(owner != null) {
                var ownerForm = ((owner as Form) == null) ? ((UserControl)owner).ParentForm : (Form)owner;
                AdjustSounds(icon);
                var msgboxControl = AdjustDialogScreen(message, title, buttons, icon, defaultButton, height, ownerForm);
                var actionDelegate = new Action<MsgBoxControl>(ModalState);
                var asyncResult = actionDelegate.BeginInvoke(msgboxControl, null, actionDelegate);
                bool canceled = false;
                try {
                    while(!asyncResult.IsCompleted) {
                        Thread.Sleep(1);
                        Application.DoEvents();
                    }
                } catch {
                    canceled = true;
                    if(!asyncResult.IsCompleted) {
                        try {
                            asyncResult = null;
                        } catch { }
                    }
                    actionDelegate = null;
                }
                if(!canceled) {
                    _result = msgboxControl.Result;
                    msgboxControl.Dispose();
                }
            }
            return _result;
        }

        private static MsgBoxControl AdjustDialogScreen
            (string message, string title, MessageBoxButtons buttons,
            MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, int height,
            Form ownerForm)
        {
            var msgboxControl = new MsgBoxControl {
                BackColor = ownerForm.BackColor
            };
            msgboxControl.Properties.Buttons = buttons;
            msgboxControl.Properties.DefaultButton = defaultButton;
            msgboxControl.Properties.Icon = icon;
            msgboxControl.Properties.Message = message;
            msgboxControl.Properties.Title = title;
            msgboxControl.Padding = new Padding(0, 0, 0, 0);
            msgboxControl.ControlBox = false;
            msgboxControl.ShowInTaskbar = false;
            msgboxControl.TopMost = true;
            msgboxControl.Size = new Size(ownerForm.Size.Width - 100, height);
            msgboxControl.Location = new Point(ownerForm.Location.X + (ownerForm.Width - msgboxControl.Width) / 2, ownerForm.Location.Y + (ownerForm.Height - msgboxControl.Height) / 2);
            msgboxControl.AdjustAppearance();
            int _overlaySizes = Convert.ToInt32(Math.Floor(msgboxControl.Size.Height * 0.28));
            msgboxControl.ShowDialog();
            msgboxControl.BringToFront();
            msgboxControl.SetDefaultButton();
            return msgboxControl;
        }


        private static void AdjustSounds(MessageBoxIcon icon)
        {
            switch(icon) {
                case MessageBoxIcon.Error:
                    SystemSounds.Hand.Play();
                    break;
                case MessageBoxIcon.Exclamation:
                    SystemSounds.Exclamation.Play();
                    break;
                case MessageBoxIcon.Question:
                    SystemSounds.Beep.Play();
                    break;
                default:
                    SystemSounds.Asterisk.Play();
                    break;
            }
        }


        private static void ModalState(MsgBoxControl control)
        {
            while(control.Visible) { }
        }



    }
}
