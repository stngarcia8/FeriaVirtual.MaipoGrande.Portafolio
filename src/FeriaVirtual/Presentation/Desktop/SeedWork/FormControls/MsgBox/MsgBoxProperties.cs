using System.Windows.Forms;

namespace FeriaVirtual.App.Desktop.SeedWork.FormControls.MsgBox
{
    public class MsgBoxProperties
    {
        public MessageBoxButtons Buttons { get; set; }
        public MessageBoxDefaultButton DefaultButton { get; set; }
        public MessageBoxIcon Icon { get; set; }
        public string Message { get; set; }
        public MsgBoxControl Owner { get; }
        public string Title { get; set; }


        public MsgBoxProperties(MsgBoxControl owner) =>
            Owner = owner;





    }
}
