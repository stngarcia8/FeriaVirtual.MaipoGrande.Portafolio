using Microsoft.Extensions.DependencyInjection;

namespace FeriaVirtual.App.Desktop.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        private static ServiceCollection _services;

        public static ServiceProvider GetProvider =>
            _services?.BuildServiceProvider();


        public static ServiceCollection GetServices =>
            _services is null ? null : _services;


        public static void RegisterServices()
        {
            _services = new ServiceCollection();
            _services.AddApplication();
        }


    }
}
