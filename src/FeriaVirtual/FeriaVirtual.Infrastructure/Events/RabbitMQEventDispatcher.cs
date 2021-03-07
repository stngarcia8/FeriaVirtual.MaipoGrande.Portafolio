using FeriaVirtual.Domain.SeedWork.Events;
using FeriaVirtual.Infrastructure.Events.RabbitMQ;

namespace FeriaVirtual.Infrastructure.Events
{
    class RabbitMQEventDispatcher
        : IEventDispatcher
    {
        private readonly RabbitMQPublisher _publisher;


        public RabbitMQEventDispatcher() =>
            _publisher = new RabbitMQPublisher();

        public void Dispatch(DomainEventBase domainEvent)
        {
            var exchangeName = "DomainEvents";
            var eventName = domainEvent.EventName();
            var body = domainEvent.Body;
            _publisher.Publish(exchangeName, eventName, body);
        }






    }
}
