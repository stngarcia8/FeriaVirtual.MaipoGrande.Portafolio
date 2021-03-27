using Microsoft.Extensions.DependencyInjection;

namespace FeriaVirtual.Infrastructure.IOC.Extensions.DependencyInjection
{
    public static class Application
    {
        public static IServiceCollection AddApplication
            (this IServiceCollection services)
        {
            services.AddCommandServices(AssemblyHelper.GetInstance(Assemblies.Application));
            services.AddQueryServices(AssemblyHelper.GetInstance(Assemblies.Application));
            return services;
        }


    }
}
