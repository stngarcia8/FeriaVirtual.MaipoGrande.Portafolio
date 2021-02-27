using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Infrastructure.Persistence.RelationalRepositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FeriaVirtual.IOC.Extension.DependencyInjection
{
    public static class Infrastructure
    {
        public static IServiceCollection AddInfrastructure
            (this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }


    }
}
