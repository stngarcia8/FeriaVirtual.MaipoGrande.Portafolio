using System.Collections.Generic;
using FeriaVirtual.Domain.SeedWork.Events;
using FeriaVirtual.Infrastructure.Persistence;
using FeriaVirtual.Infrastructure.Persistence.OracleContext;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration;

namespace FeriaVirtual.Infrastructure.Events.DBEventStore
{
    public class RepositoryEventStore
        : IEventSuscriber
    {
        private readonly IUnitOfWork _unitOfWork;

        public RepositoryEventStore() =>
            _unitOfWork = new UnitOfWork(ContextManager.BuildContext(EventStoreConfig.Build()));

        public void Dispatch(DomainEventBase domainEvent)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object> {
                {"EventId", domainEvent.EventId.ToString()},
                {"Name", domainEvent.EventName() },
                {"Body", domainEvent.Serialize() },
                {"OcurredOn", domainEvent.OcurredOn }
            };
            _unitOfWork.Context.SaveByStoredProcedure("sp_add_event", parameters);
            _unitOfWork.SaveChanges();
        }
    }
}
