using System;
using System.Collections.Generic;
using System.Text;
using RabbitMQ.Client;
namespace FeriaVirtual.Infrastructure.Events.RabbitMQ
{
    class RabbitMQConfiguration
    {
        public ConnectionFactory ConnectionFactory { get; }
        private static IConnection _connection { get; set; }
        private static IModel _channel { get; set; }

        public RabbitMQConfiguration()
        {
            var parameters = RabbitMQParameters.GetParameters();
            ConnectionFactory =  new ConnectionFactory { 
                HostName = parameters.HostName,
                UserName= parameters.UserName,
                Password= parameters.Password,
                Port= parameters.Port
            };
        }

        public IConnection Connection()
        {
            if(_connection==null) _connection= ConnectionFactory.CreateConnection();
            return _connection;
        }

        public IModel Channel()
        {
            if(_channel is null) _channel= Connection().CreateModel();
            return _channel;
        }


        


    }
}
