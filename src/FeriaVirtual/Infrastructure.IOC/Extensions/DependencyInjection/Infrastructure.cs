using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Commands;
using FeriaVirtual.Domain.SeedWork.Query;
using FeriaVirtual.Infrastructure.Persistence.RelationalRepositories;
using FeriaVirtual.Infrastructure.SeedWork.Commands;
using FeriaVirtual.Infrastructure.SeedWork.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace FeriaVirtual.Infrastructure.IOC.Extensions.DependencyInjection
{
    public static class Infrastructure
    {
        public static IServiceCollection AddInfrastructure
            (this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISessionRepository, SessionRepository>();

            //services.AddScoped<IEventPublisher, EventPublisher>();

            services.AddScoped<ICommandBus, InMemoryCommandBus>();
            services.AddScoped<IQueryBus, InMemoryQueryBus>();
            return services;
        }


    }
}
