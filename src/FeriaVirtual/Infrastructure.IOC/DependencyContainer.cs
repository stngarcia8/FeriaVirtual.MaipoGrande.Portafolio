using FeriaVirtual.Infrastructure.IOC.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace FeriaVirtual.Infrastructure.IOC
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
