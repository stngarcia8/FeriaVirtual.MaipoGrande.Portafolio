using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Commands;
using FeriaVirtual.Infrastructure.Persistence.RelationalRepositories;
using FeriaVirtual.Infrastructure.SeedWork.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace FeriaVirtual.Infrastructure.IOC.Extensions.DependencyInjection
{
    public static class Infrastructure
    {
        public static IServiceCollection AddInfrastructure
            (this IServiceCollection services)
        {
            // repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISessionRepository, SessionRepository>();

            // events
            //services.AddScoped<IEventPublisher, EventPublisher>();

            // Agregar command bus
            services.AddScoped<ICommandBus, InMemoryCommandBus>();
            return services;
        }


    }
}
