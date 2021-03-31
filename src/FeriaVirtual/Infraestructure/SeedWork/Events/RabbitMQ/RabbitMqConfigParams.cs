namespace FeriaVirtual.Infrastructure.SeedWork.Events.RabbitMQ
{
    public class RabbitMqConfigParams
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Hostname { get; set; }
        public int Port { get; set; }


        public RabbitMqConfigParams()
        {
            var config = LoadConfiguration.Load().GetConfiguration;
            Username = config["RabbitMQ:Username"];
            Password = config["RabbitMQ:Password"];
            Hostname = config["RabbitMQ:Hostname"];
            Port = int.Parse(config["RabbitMQ:Port"]);
        }

    }
}
