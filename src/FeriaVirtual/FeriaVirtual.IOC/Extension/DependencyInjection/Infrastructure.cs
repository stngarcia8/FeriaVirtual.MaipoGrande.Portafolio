using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Events;
using FeriaVirtual.Infrastructure.Events;
using FeriaVirtual.Infrastructure.Persistence.RelationalRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace FeriaVirtual.IOC.Extension.DependencyInjection
{
    public static class Infrastructure
    {
        public static IServiceCollection AddInfrastructure
            (this IServiceCollection services)
        {
            // repositories
            services.AddScoped<IUserRepository, UserRepository>();

            // events
            services.AddScoped<IEventPublisher, EventPublisher>();
            return services;
        }


    }
}
