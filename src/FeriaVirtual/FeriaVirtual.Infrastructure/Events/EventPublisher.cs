using System.Collections.Generic;
using FeriaVirtual.Domain.SeedWork.Events;
using FeriaVirtual.Infrastructure.Events.DBEventStore;
using FeriaVirtual.Infrastructure.Events.RabbitMQ;

namespace FeriaVirtual.Infrastructure.Events
{
    public class EventPublisher
        : IEventPublisher
    {
        private readonly IList<IEventSuscriber> _suscribers;

        public EventPublisher() =>
            _suscribers = new List<IEventSuscriber> {
                new RepositoryEventStore(),
                new RabbitMQEventStore()
            };


        public void Publish(IList<DomainEventBase> domainEvents)
        {
            if (_suscribers.Count.Equals(0)) return;
            foreach (var domainEvent in domainEvents) {
                PublishEvent(domainEvent);
            }
        }

        private void PublishEvent(DomainEventBase domainEvent)
        {
            foreach (var suscriber in _suscribers)
                suscriber.Dispatch(domainEvent);
        }


    }
}
