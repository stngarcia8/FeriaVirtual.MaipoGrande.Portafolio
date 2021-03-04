using System.Collections.Generic;
using System.Text;
using RabbitMQ.Client;

namespace FeriaVirtual.Infrastructure.Events.RabbitMQ
{
    class RabbitMQPublisher
    {
        private RabbitMQConfiguration _configuration;

        public RabbitMQPublisher(RabbitMQConfiguration configuration) =>
            _configuration = configuration;

        public void Publish
            (string exchangeName, string eventName, string message)
        {
            var channel = _configuration.Channel();
            var routingKey = $"{exchangeName}.{eventName}"; 
            channel.ExchangeDeclare(exchangeName, ExchangeType.Topic);
            var body = Encoding.UTF8.GetBytes(message);
            var props = channel.CreateBasicProperties();
            props.ContentType = "text/plain";
            props.DeliveryMode = 2;
            channel.BasicPublish(exchangeName, routingKey, props, body);
        }

    }
}
