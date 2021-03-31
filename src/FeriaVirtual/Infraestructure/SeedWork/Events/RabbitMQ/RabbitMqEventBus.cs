using FeriaVirtual.Domain.SeedWork.Events;
using RabbitMQ.Client.Exceptions;
using System;

namespace FeriaVirtual.Infrastructure.SeedWork.Events.RabbitMQ
{
    public class RabbitMqEventBus
        : IEventBus
    {
        private readonly string _exchangeName;
        private readonly RabbitMqPublisher _rabbitMqPublisher;


        public RabbitMqEventBus
            (RabbitMqPublisher rabbitMqPublisher, string exchangeName = "domain_events")
        {
            _rabbitMqPublisher = rabbitMqPublisher;
            _exchangeName = exchangeName;
        }


        public void Publish(DomainEventCollection eventCollection)
        {
            foreach (var e in eventCollection.GetEvents)
                Publish(e);
        }


        private void Publish(DomainEventBase domainEvent)
        {
            try {
                var serializedDomainEvent = DomainEventJsonSerializer.Serialize(domainEvent);
                _rabbitMqPublisher.Publish(_exchangeName, domainEvent.EventName(), serializedDomainEvent);
            } catch (RabbitMQClientException ex) {
                throw new Exception(ex.Message);
            }
        }


    }
}
