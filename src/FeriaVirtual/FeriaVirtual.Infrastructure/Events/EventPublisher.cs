using System.Collections.Generic;
using FeriaVirtual.Domain.SeedWork.Events;

namespace FeriaVirtual.Infrastructure.Events
{
    public class EventPublisher
        : IEventPublisher
    {
        private readonly IList<IEventDispatcher> _suscribers;

        public EventPublisher() =>
            _suscribers = new List<IEventDispatcher> {
                new RepositoryEventDispatcher()
                // new RabbitMQEventDispatcher()
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
