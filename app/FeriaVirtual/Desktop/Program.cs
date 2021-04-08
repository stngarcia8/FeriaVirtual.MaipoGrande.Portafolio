using FeriaVirtual.App.Desktop.Extensions.DependencyInjection;
using FeriaVirtual.App.Desktop.Forms.MainForms;
using FeriaVirtual.App.Desktop.Forms.SignIn;
using System;

namespace FeriaVirtual.App.Desktop
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            DependencyContainer.RegisterServices();
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new AdminForm());
        }


    }
}
