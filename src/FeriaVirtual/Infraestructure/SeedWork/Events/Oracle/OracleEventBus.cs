using FeriaVirtual.Domain.SeedWork.Events;
using FeriaVirtual.Infrastructure.Persistence.OracleContext;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeriaVirtual.Infrastructure.SeedWork.Events.Oracle
{
    public class OracleEventBus
        : IEventBus
    {
        private readonly IUnitOfWork _unitOfWork;


        public OracleEventBus() =>
            _unitOfWork = new UnitOfWork(ContextManager.BuildContext(EventStoreConfig.Build()));


        public async  Task PublishAsync(DomainEventCollection evenCollection)
        {
            foreach (var domainEvent in evenCollection.GetEvents)
                await PublishAsync(domainEvent);
        }


        private async Task PublishAsync(DomainEventBase domainEvent)
        {
            Dictionary<string, object> parameters = new() {
                { "EventId", domainEvent.EventId.Value.ToString() },
                { "Name", domainEvent.EventName() },
                { "Body", DomainEventJsonSerializer .Serialize(domainEvent) },
                { "OcurredOn", domainEvent.OcurredOn }
            };

            var tasks = Task.WhenAll(
                _unitOfWork.Context.OpenContextAsync(),
                _unitOfWork.Context.SaveByStoredProcedure("sp_add_event", parameters),
                _unitOfWork.SaveChangesAsync()
                );
            await tasks;
        }


    }
}
