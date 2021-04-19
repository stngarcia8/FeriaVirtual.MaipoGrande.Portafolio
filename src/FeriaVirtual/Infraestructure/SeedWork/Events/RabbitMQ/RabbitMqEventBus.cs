using FeriaVirtual.Domain.SeedWork.Events;
using RabbitMQ.Client.Exceptions;
using System;
using System.Threading.Tasks;

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


        public async Task PublishAsync(DomainEventCollection eventCollection)
        {
            foreach (var e in eventCollection.GetEvents)
                await Publish(e);
        }


        private async Task  Publish(DomainEventBase domainEvent)
        {
            try {
                var serializedDomainEvent = DomainEventJsonSerializer.Serialize(domainEvent);
                await Task.Run(() => _rabbitMqPublisher.Publish(_exchangeName, domainEvent.EventName(), serializedDomainEvent));
            } catch (RabbitMQClientException ex) {
                throw new Exception(ex.Message);
            }
        }


    }
}
