using MetroFramework.Controls;
using System.Windows.Forms;

namespace FeriaVirtual.App.Desktop.SeedWork.FormControls.MsgBox
{
    public partial class MsgBoxControl : Form
    {
        private readonly System.Drawing.Color _defaultColor = System.Drawing.Color.FromArgb(124, 65, 153);
        private readonly System.Drawing.Color _errorColor = System.Drawing.Color.FromArgb(210, 50, 45);
        private readonly System.Drawing.Color _warningColor = System.Drawing.Color.FromArgb(237, 156, 40);
        //private readonly System.Drawing.Color _successColor = Color.FromArgb(71, 164, 71);
        private readonly System.Drawing.Color _questionColor = System.Drawing.Color.FromArgb(71, 164, 71);
        private readonly MsgBoxProperties _properties = null;
        private DialogResult _result = DialogResult.None;


        public Panel Body { get { return panelbody; } }
        public MsgBoxProperties Properties { get { return _properties; } }
        public DialogResult Result { get { return _result; } }


        public MsgBoxControl()
        {
            InitializeComponent();
            _properties = new MsgBoxProperties(this);
            SetEventToButton(metroButton1);
            SetEventToButton(metroButton2);
            SetEventToButton(metroButton3);
            metroButton1.Click += new System.EventHandler(Button_Click);
            metroButton2.Click += new System.EventHandler(Button_Click);
            metroButton3.Click += new System.EventHandler(Button_Click);
        }


        private void Button_MouseEnter
            (object sender, System.EventArgs e) =>
            SetEventToButton((MetroButton)sender, true);


        private void Button_MouseLeave
            (object sender, System.EventArgs e) =>
            SetEventToButton((MetroButton)sender);


        private void Button_Click
            (object sender, System.EventArgs e)
        {
            MetroButton button = (MetroButton)sender;
            if(!button.Enabled) {
                return;
            }
            _result = (DialogResult)button.Tag;
            Hide();
        }


        public void AdjustAppearance()
        {
            titleLabel.Text = _properties.Title;
            messageLabel.Text = _properties.Message;
            EvaluateButtonStyle();
            EvaluateIconStyle();
        }


        private void EvaluateButtonStyle()
        {
            if(_properties.Buttons.Equals(MessageBoxButtons.OK))
                MessageButtonsOk();
            if(_properties.Buttons.Equals(MessageBoxButtons.OKCancel))
                MessageButtonsOkCancel();
            if(_properties.Buttons.Equals(MessageBoxButtons.RetryCancel))
                MessageButtonsRetryCancel();
            if(_properties.Buttons.Equals(MessageBoxButtons.YesNo))
                MessageButtonsYesNo();
            if(_properties.Buttons.Equals(MessageBoxButtons.YesNoCancel))
                MessageButtonsYesNoCancel();
            if(_properties.Buttons.Equals(MessageBoxButtons.AbortRetryIgnore))
                MessageButtonsAbortRetryIgnore();
        }


        private void MessageButtonsOk()
        {
            ConfigureButton(metroButton1, "Aceptar", metroButton3, DialogResult.OK);
            EnableButtons(metroButton2, false);
            EnableButtons(metroButton3, false);
        }


        private void MessageButtonsOkCancel()
        {
            ConfigureButton(metroButton1, "Aceptar", metroButton2, DialogResult.OK);
            ConfigureButton(metroButton2, "Cancelar", metroButton3, DialogResult.Cancel);
            EnableButtons(metroButton3, false);
        }


        private void MessageButtonsRetryCancel()
        {
            ConfigureButton(metroButton1, "Reintentar", metroButton2, DialogResult.Retry);
            ConfigureButton(metroButton2, "Cancelar", metroButton3, DialogResult.Cancel);
            EnableButtons(metroButton3, false);
        }


        private void MessageButtonsYesNo()
        {
            ConfigureButton(metroButton1, "Sí", metroButton2, DialogResult.Yes);
            ConfigureButton(metroButton2, "No", metroButton3, DialogResult.No);
            EnableButtons(metroButton3, false);
        }


        private void MessageButtonsYesNoCancel()
        {
            ConfigureButton(metroButton1, "Sí", DialogResult.Yes);
            ConfigureButton(metroButton2, "No", DialogResult.No);
            ConfigureButton(metroButton3, "Cancelar", DialogResult.Cancel);
        }


        private void MessageButtonsAbortRetryIgnore()
        {
            ConfigureButton(metroButton1, "Abortar", DialogResult.Abort);
            ConfigureButton(metroButton2, "Reintentar", DialogResult.Retry);
            ConfigureButton(metroButton3, "Ignorar", DialogResult.Ignore);
        }


        private void ConfigureButton
            (MetroButton button, string buttonText,
            MetroButton button2, DialogResult result)
        {
            EnableButtons(button);
            button.Text = buttonText;
            button.Location = button2.Location;
            button.Tag = result;
        }


        private void ConfigureButton
            (MetroButton button, string textButton, DialogResult result)
        {
            EnableButtons(button);
            button.Text = textButton;
            button.Tag = result;
        }


        private void EnableButtons(MetroButton button) =>
            EnableButtons(button, true);


        private void EnableButtons
            (MetroButton button, bool enabled)
        {
            button.Enabled = enabled;
            button.Visible = enabled;
        }


        private void EvaluateIconStyle()
        {
            this.MessageStyle(System.Drawing.Color.DarkGray, -1);
            if(_properties.Icon.Equals(MessageBoxIcon.Error) || _properties.Icon.Equals(MessageBoxIcon.Hand) || _properties.Icon.Equals(MessageBoxIcon.Stop))
                this.MessageStyle(_errorColor, 0);
            if(_properties.Icon.Equals(MessageBoxIcon.Warning) || _properties.Icon.Equals(MessageBoxIcon.Exclamation))
                this.MessageStyle(_warningColor, 3);
            if(_properties.Icon.Equals(MessageBoxIcon.Information) || _properties.Icon.Equals(MessageBoxIcon.Asterisk))
                this.MessageStyle(_defaultColor, 1);
            if(_properties.Icon.Equals(MessageBoxIcon.Question))
                this.MessageStyle(_questionColor, 2);
        }


        private void MessageStyle
            (System.Drawing.Color color, int imageIndex)
        {
            panelbody.BackColor = color;
            iconLabel.ImageIndex = imageIndex;
        }


        public void SetDefaultButton()
        {
            if(_properties.DefaultButton.Equals(MessageBoxDefaultButton.Button1))
                this.ConfigureDefaultButton(metroButton1);
            if(_properties.DefaultButton.Equals(MessageBoxDefaultButton.Button2))
                this.ConfigureDefaultButton(metroButton2);
            if(_properties.DefaultButton.Equals(MessageBoxDefaultButton.Button3))
                this.ConfigureDefaultButton(metroButton3);
        }


        private void ConfigureDefaultButton(MetroButton button)
        {
            if(button is null || !button.Enabled) {
                return;
            }
            button.Focus();
        }


        private void SetEventToButton(MetroButton button) =>
            SetEventToButton(button, false);

        private void SetEventToButton
            (MetroButton button, bool hovered)
        {
            button.Cursor = Cursors.Hand;
            button.MouseEnter -= Button_MouseEnter;
            button.MouseEnter += Button_MouseEnter;
            button.MouseLeave -= Button_MouseLeave;
            button.MouseLeave += Button_MouseLeave;
        }


    }
}
