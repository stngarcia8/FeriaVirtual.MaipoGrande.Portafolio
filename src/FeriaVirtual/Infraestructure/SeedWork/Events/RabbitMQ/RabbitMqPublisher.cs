﻿using RabbitMQ.Client;
using System.Collections.Generic;
using System.Text;

namespace FeriaVirtual.Infrastructure.SeedWork.Events.RabbitMQ
{
    public class RabbitMqPublisher
    {
        private const string HeaderReDelivery = "redelivery_count";
        private readonly RabbitMqConfig _config;


        public RabbitMqPublisher() => 
            _config = new RabbitMqConfig();


        public void Publish(string exchangeName, string eventName, string message)
        {
            var channel = _config.Channel();
            channel.ExchangeDeclare(exchangeName, ExchangeType.Topic);
            var body = Encoding.UTF8.GetBytes(message);
            var properties = channel.CreateBasicProperties();
            properties.Headers = new Dictionary<string, object>
            {
                {HeaderReDelivery, 0}
            };
            channel.BasicPublish(exchangeName,eventName, properties, body);
        }


    }
}
