using System;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using Polly;
using Polly.Retry;
using RabbitMQ.Client;
using RabbitMQ.Client.Exceptions;

namespace FeriaVirtual.Infrastructure.Events.RabbitMQ
{
    class RabbitMQPublisher
    {
        private readonly IRabbitMQPersistentConnection _connection;
        private readonly int _retryCount;

        public RabbitMQPublisher(int retryCount = 5)
        {
            _connection = new RabbitMQPersistentConnection();
            _retryCount = retryCount;
        }

        public void Publish
            (string exchangeName, string eventName, object body)
        {
            if (!_connection.IsConnected) {
                _connection.TryConnect();
            }
            var policy = RetryPolicy.Handle<BrokerUnreachableException>()
                .Or<SocketException>()
                .WaitAndRetry(_retryCount, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)), (ex, time) => { });
            var routingKey = $"{exchangeName}.{eventName}";
            using (var channel = _connection.CreateModel()) {
                channel.ExchangeDeclare(exchange: exchangeName, type: "direct", true);
                var message = JsonConvert.SerializeObject(body);
                var bodyConverter = Encoding.UTF8.GetBytes(message);
                policy.Execute(() => {
                    var properties = channel.CreateBasicProperties();
                    properties.DeliveryMode = 2;
                    channel.BasicPublish(
                        exchange: exchangeName,
                        routingKey: routingKey,
                        mandatory: true,
                        basicProperties: properties,
                        body: bodyConverter);
                });
            }

        }



    }
}
