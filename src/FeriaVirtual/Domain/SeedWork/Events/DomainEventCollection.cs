using System.Collections.Generic;

namespace FeriaVirtual.Domain.SeedWork.Events
{
    public class DomainEventCollection
    {
        private readonly IList<DomainEventBase> _events;
        public IList<DomainEventBase> GetEvents => _events;


        public DomainEventCollection() =>
            _events = new List<DomainEventBase>();

        public void AddEvent(DomainEventBase domainEvent) =>
            _events.Add(domainEvent);

        public void RemoveEvent(DomainEventBase domainEvent) =>
            _events.Remove(domainEvent);

        public void ClearEvents() =>
            _events.Clear();

        public void Publish(IEventBus eventBus)
        {
            eventBus.Publish(_events);
            _events.Clear();
        }

    }
}
