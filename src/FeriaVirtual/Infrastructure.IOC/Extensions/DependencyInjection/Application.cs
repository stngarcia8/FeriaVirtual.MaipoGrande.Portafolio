using FeriaVirtual.Application.Users.Interfaces;
using FeriaVirtual.Application.Users.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FeriaVirtual.Infrastructure.IOC.Extensions.DependencyInjection
{
    public static class Application
    {
        public static IServiceCollection AddApplication
            (this IServiceCollection services)
        {
            // User services
            services.AddScoped<ISignInUserService, SignInUserService>();
            services.AddScoped<IQueryUserService, QueryUserService>();

            // Command services
            services.AddCommandServices(AssemblyHelper.GetInstance(Assemblies.Application));

            return services;
        }


    }
}
