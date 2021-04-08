using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System.Collections.Generic;

namespace FeriaVirtual.App.Desktop.SeedWork.FormControls
{
    public class ThemeManager
    {
        private readonly MetroStyleManager _styleManager;
        private readonly MetroForm _form;

        public MetroThemeStyle Style => _styleManager.Theme;


        private ThemeManager(MetroForm form)
        {
            _form = form;
            _styleManager = new MetroStyleManager {
                Owner = _form
            };
        }

        public static ThemeManager SuscribeForm(MetroForm form) =>
            new ThemeManager(form);


        public void DarkMode()
        {
            _styleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            _form.Theme = _styleManager.Theme;
        }

        public void LightMode()
        {
            _styleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            _form.Theme = _styleManager.Theme;
        }

        public void ChangeColorStyle(MetroColorStyle colorStyle)
        {
            _styleManager.Style = colorStyle;
            _form.Style = _styleManager.Style;
        }

        public IList<string> GetAvailableColors() =>
            new List<string>() {
                    "Black", "White", "Silver", "Blue", "Green",
                    "Lime", "Teal", "Orange", "Brown",
                    "Pink", "Magenta", "Purple", "Red", "Yellow"
            };



    }
}
