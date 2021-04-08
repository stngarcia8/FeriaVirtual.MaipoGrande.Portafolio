using FeriaVirtual.App.Desktop.Services.SignIn;
using Microsoft.Extensions.DependencyInjection;

namespace FeriaVirtual.App.Desktop.Extensions.DependencyInjection
{
    public static class Application
    {
        public static IServiceCollection AddApplication
            (this IServiceCollection services)
        {
            services.AddHttpClient<ISigninService, SigninService>();
            services.AddScoped<ISigninService, SigninService>();
            return services;
        }


    }
}
