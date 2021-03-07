namespace FeriaVirtual.Infrastructure.Events.RabbitMQ
{
    sealed class RabbitMQParameters
    {
        public string HostName { get; }
        public string Password { get; }
        public string UserName { get; }
        public int Port { get; }


        private RabbitMQParameters()
        {
            var config = LoadConfiguration.Load().GetConfiguration;
            HostName = config["RabbitMQ:Hostname"];
            Password = config["RabbitMQ:Password"];
            UserName = config["RabbitMQ:Username"];
            Port = int.Parse(config["RabbitMQ:Port"]);
        }

        public static RabbitMQParameters Value() =>
            new RabbitMQParameters();


    }
}
