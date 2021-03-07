using System;
using RabbitMQ.Client;

namespace FeriaVirtual.Infrastructure.Events.RabbitMQ
{
    public interface IRabbitMQPersistentConnection
        : IDisposable
    {
        bool IsConnected { get; }
        IModel CreateModel();
        bool TryConnect();


    }
}
