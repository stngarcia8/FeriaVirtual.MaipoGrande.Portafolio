using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Commands;
using FeriaVirtual.Domain.SeedWork.Events;
using FeriaVirtual.Domain.SeedWork.Query;
using FeriaVirtual.Infrastructure.Persistence.RelationalRepositories;
using FeriaVirtual.Infrastructure.SeedWork;
using FeriaVirtual.Infrastructure.SeedWork.Commands;
using FeriaVirtual.Infrastructure.SeedWork.Events;
using FeriaVirtual.Infrastructure.SeedWork.Events.Oracle;
using FeriaVirtual.Infrastructure.SeedWork.Events.RabbitMQ;
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
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<ISessionRepository, SessionRepository>();

            services.AddScoped<InMemoryApplicationEventBus, InMemoryApplicationEventBus>();
            services.AddScoped<IEventBus, OracleEventBus>();
            services.AddScoped<IEventBus, RabbitMqEventBus>();
            services.AddScoped<RabbitMqPublisher, RabbitMqPublisher>();
            services.AddScoped<DomainEventsInformation, DomainEventsInformation>();
            services.AddScoped<DomainEventJsonDeserializer, DomainEventJsonDeserializer>();

            services.AddScoped<ICommandBus, InMemoryCommandBus>();
            services.AddScoped<IQueryBus, InMemoryQueryBus>();
            return services;
        }


    }
}
