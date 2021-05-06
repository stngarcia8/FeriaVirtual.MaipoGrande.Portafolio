using FeriaVirtual.App.Desktop.SeedWork.Helpers.Preferences;
using Microsoft.Extensions.Configuration;
using FeriaVirtual.App.Desktop.Services.Employees;
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
            services.AddHttpClient<IEmployeeService, EmployeeService>();
            services.AddScoped<ISigninService, SigninService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            return services;
        }


    }
}
