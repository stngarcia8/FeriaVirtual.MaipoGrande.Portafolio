using RabbitMQ.Client;

namespace FeriaVirtual.Infrastructure.SeedWork.Events.RabbitMQ
{
    public class RabbitMqConfig
    {
        public ConnectionFactory ConnectionFactory { get; }
        private static IConnection RmqConnection { get; set; }
        private static IModel RmqChannel { get; set; }


        public RabbitMqConfig()
        {
            var configParams = new RabbitMqConfigParams();
            ConnectionFactory = new ConnectionFactory {
                HostName = configParams.Hostname,
                UserName = configParams.Username,
                Password = configParams.Password,
                Port = configParams.Port
            };
        }


        public IConnection Connection()
        {
            if(RmqConnection == null)
                RmqConnection = ConnectionFactory.CreateConnection();
            return RmqConnection;
        }


        public IModel Channel()
        {
            if(RmqChannel == null)
                RmqChannel = Connection().CreateModel();
            return RmqChannel;
        }


    }
}
