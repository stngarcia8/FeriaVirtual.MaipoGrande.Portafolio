using FeriaVirtual.Domain.SeedWork.Events;
using FeriaVirtual.Infrastructure.Persistence.OracleContext;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration;
using System.Collections.Generic;

namespace FeriaVirtual.Infrastructure.SeedWork.Events.Oracle
{
    public class OracleEventBus
        : IEventBus
    {
        private readonly IUnitOfWork _unitOfWork;


        public OracleEventBus() =>
            _unitOfWork = new UnitOfWork(ContextManager.BuildContext(EventStoreConfig.Build()));


        public void Publish(DomainEventCollection evenCollection)
        {
            foreach (var domainEvent in evenCollection.GetEvents)
                Publish(domainEvent);
        }


        private void Publish(DomainEventBase domainEvent)
        {
            Dictionary<string, object> parameters = new() {
                { "EventId", domainEvent.EventId.ToString() },
                { "Name", domainEvent.EventName() },
                { "Body", domainEvent.ToPrimitives() },
                { "OcurredOn", domainEvent.OcurredOn.ToString() }
            };

            _unitOfWork.Context.SaveByStoredProcedure("sp_add_event", parameters);
            _unitOfWork.SaveChanges();
        }



    }
}
