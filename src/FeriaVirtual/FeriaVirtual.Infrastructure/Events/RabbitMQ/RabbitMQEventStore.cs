using System;
using System.Collections.Generic;
using System.Text;
using FeriaVirtual.Domain.SeedWork.Events;

namespace FeriaVirtual.Infrastructure.Events.RabbitMQ
{
    class RabbitMQEventStore
        :IEventSuscriber
    {
        private RabbitMQPublisher _publisher;


        public RabbitMQEventStore() =>
            _publisher = new RabbitMQPublisher(new RabbitMQConfiguration());

        public void Dispatch(DomainEventBase domainEvent)
        {
            var exchangeName = "domain_events";
            var eventName = domainEvent.EventName();
            var message = domainEvent.Serialize();
            _publisher.Publish(exchangeName, eventName, message);
        }






    }
}
