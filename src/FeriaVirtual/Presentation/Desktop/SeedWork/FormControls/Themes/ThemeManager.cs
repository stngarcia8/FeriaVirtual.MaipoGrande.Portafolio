using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System.Collections.Generic;

namespace FeriaVirtual.App.Desktop.SeedWork.FormControls.Themes
{
    public class ThemeManager
    {
        private readonly MetroStyleManager _styleManager;
        private readonly MetroForm _form;

        public MetroThemeStyle Style => _styleManager.Theme;
        public IList<ColorStyle> AvailableColors { get; protected set; }
        public bool IsDarkMode { get; protected set; }
        public MetroColorStyle ColorStyle { get; protected set; }


        private ThemeManager(MetroForm form)
        {
            _form = form;
            _styleManager = new MetroStyleManager {
                Owner = _form
            };
            DefineStyles();
        }

        public static ThemeManager SuscribeForm(MetroForm form) =>
            new ThemeManager(form);


        public void Initialize(int colorSchema, int mode)
        {
            ChangeColorStyle((MetroColorStyle)colorSchema);
            if(mode.Equals(1))
                this.DarkMode();
            else
                this.LightMode();
        }


        public void DarkMode()
        {
            _styleManager.Theme = MetroThemeStyle.Dark;
            _form.Theme = _styleManager.Theme;
            _form.Refresh();
            IsDarkMode = true;
        }

        public void LightMode()
        {
            _styleManager.Theme = MetroThemeStyle.Light;
            _form.Theme = _styleManager.Theme;
            _form.Refresh();
            IsDarkMode = false;
        }

        public void ChangeColorStyle(MetroColorStyle colorStyle)
        {
            _styleManager.Style = colorStyle;
            _form.Style = _styleManager.Style;
            _form.Refresh();
            ColorStyle = colorStyle;
        }


        private void DefineStyles()
            => AvailableColors = new List<ColorStyle> {
                new ColorStyle("Negro", MetroColorStyle.Black),
                new ColorStyle("Blanco", MetroColorStyle.White),
                new ColorStyle("Gris", MetroColorStyle.Silver),
                new ColorStyle("Azul", MetroColorStyle.Blue),
                new ColorStyle("Verde", MetroColorStyle.Green),
                new ColorStyle("Naranja", MetroColorStyle.Orange),
                new ColorStyle("Magenta", MetroColorStyle.Magenta),
                new ColorStyle("Purpura", MetroColorStyle.Purple),
                new ColorStyle("Rojo", MetroColorStyle.Red),
                new ColorStyle("Amarillo", MetroColorStyle.Yellow)
            };



    }
}
