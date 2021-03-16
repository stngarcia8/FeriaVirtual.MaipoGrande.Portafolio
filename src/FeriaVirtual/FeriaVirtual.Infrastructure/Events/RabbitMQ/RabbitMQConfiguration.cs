using RabbitMQ.Client;
namespace FeriaVirtual.Infrastructure.Events.RabbitMQ
{
    sealed class RabbitMQConfiguration
    {
        private ConnectionFactory _connectionFactory;


        public RabbitMQConfiguration() =>
            ConfigureConnectionFactory();

        private void ConfigureConnectionFactory()
        {
            var parameters = RabbitMQParameters.Value();
            _connectionFactory = new ConnectionFactory {
                HostName = parameters.HostName,
                UserName = parameters.UserName,
                Password = parameters.Password
            };
        }

        public IConnectionFactory GetConnection() =>
            _connectionFactory;


    }
}
