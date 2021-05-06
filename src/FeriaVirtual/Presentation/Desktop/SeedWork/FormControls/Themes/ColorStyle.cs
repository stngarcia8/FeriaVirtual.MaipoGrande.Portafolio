using MetroFramework;

namespace FeriaVirtual.App.Desktop.SeedWork.FormControls.Themes
{
    public class ColorStyle
    {
        public string ColorName { get; }
        public MetroColorStyle Style { get; }

        public ColorStyle(string colorName, MetroColorStyle style)
        {
            ColorName = colorName;
            Style = style;
            ;
        }


    }
}
