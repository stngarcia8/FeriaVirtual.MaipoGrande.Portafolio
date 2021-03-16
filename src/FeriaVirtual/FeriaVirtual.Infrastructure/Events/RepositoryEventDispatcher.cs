using System.Collections.Generic;
using FeriaVirtual.Domain.SeedWork.Events;
using FeriaVirtual.Infrastructure.Persistence.OracleContext;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration;
using FeriaVirtual.Infrastructure.SeedWork;

namespace FeriaVirtual.Infrastructure.Events
{
    public class RepositoryEventDispatcher
        : IEventDispatcher
    {
        private readonly IUnitOfWork _unitOfWork;

        public RepositoryEventDispatcher() =>
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
