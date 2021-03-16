using FeriaVirtual.IOC.Extension.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace FeriaVirtual.IOC
{
    public static class DependencyContainer
    {
        public static ServiceProvider GetServiceProvider()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddApplication();
            serviceCollection.AddInfrastructure();
            return serviceCollection.BuildServiceProvider();
        }


    }
}
