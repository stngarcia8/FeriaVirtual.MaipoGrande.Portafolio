using FeriaVirtual.App.Desktop.Extensions.DependencyInjection;
using FeriaVirtual.App.Desktop.Forms.MainForms;
using FeriaVirtual.App.Desktop.SeedWork.Helpers.Preferences;

namespace FeriaVirtual.App.Desktop
{
    static class Program
    {

        [System.STAThread]
        static void Main()
        {
            DependencyContainer.RegisterServices();

            var preferences = Preference.Build();
            preferences.ReadSettings();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new AdminForm());
        }


    }
}
