using FeriaVirtual.App.Desktop.SeedWork.Helpers.Utils;
using MaterialSkin;
using MaterialSkin.Controls;

namespace FeriaVirtual.App.Desktop.SeedWork.FormsControls
{
    public class ThemeManager
    {
        private MaterialSkinManager _skinManager;

        private ThemeManager(MaterialForm form) =>
            ConfigureFormManager(form);


        public static ThemeManager SubscribeForm(MaterialForm form) =>
            new ThemeManager(form);


        private void ConfigureFormManager(MaterialForm form)
        {
            _skinManager = MaterialSkinManager.Instance;
            _skinManager.AddFormToManage(form);
            SetFormTheme();
            SetFormSchemaColor();
        }


        private void SetFormTheme()
        {
            _skinManager.Theme = PreferenceData.DarkMode.Equals(1)
                ? MaterialSkinManager.Themes.DARK
                : MaterialSkinManager.Themes.LIGHT;
        }


        private void SetFormSchemaColor()
        {
            switch (PreferenceData.ColorSchema) {
                case 0:
                    _skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 1:
                    _skinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    break;
                case 2:
                    _skinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    break;
                case 3:
                    _skinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red700, Primary.Red200, Accent.Yellow100, TextShade.WHITE);
                    break;
                case 4:
                    _skinManager.ColorScheme= new ColorScheme(Primary.Purple600, Primary.Purple700, Primary.Purple200, Accent.Yellow100, TextShade.WHITE);
                    break;
                case 5:
                    _skinManager.ColorScheme= new ColorScheme(Primary.Purple600, Primary.Purple700, Primary.Purple200, Accent.Yellow100, TextShade.WHITE);
                    break;
            }
        }


        public void ChangeTheme(int darkMode)
        {
            PreferenceData.DarkMode = darkMode;
            SetFormTheme();
        }


        public void ChangeColorSchema(int colorSchema)
        {
            PreferenceData.ColorSchema = colorSchema;
            SetFormSchemaColor();
        }
            

        public void UnsubscribeForm(MaterialForm form) =>
            _skinManager.RemoveFormToManage(form);








    }
}
