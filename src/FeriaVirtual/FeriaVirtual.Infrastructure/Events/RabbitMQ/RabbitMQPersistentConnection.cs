using System;
using System.IO;
using System.Net.Sockets;
using Polly;
using Polly.Retry;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Client.Exceptions;

namespace FeriaVirtual.Infrastructure.Events.RabbitMQ
{
    public class RabbitMQPersistentConnection : IRabbitMQPersistentConnection
    {
        private readonly IConnectionFactory _connectionFactory;
        private readonly int _retryCount;
        private IConnection _connection;
        private bool _disposed;
        private readonly object sync_root = new object();

        public bool IsConnected {
            get { return _connection != null && _connection.IsOpen && !_disposed; }
        }


        public RabbitMQPersistentConnection(int retryCount = 5)
        {
            RabbitMQConfiguration configuration = new RabbitMQConfiguration();
            _connectionFactory = configuration.GetConnection();
            _retryCount = retryCount;
        }

        public IModel CreateModel()
        {
            if (!IsConnected)
                throw new InvalidOperationException("No hay conexiones a RabbitMQ disponibles en este momento.");
            return _connection.CreateModel();
        }

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            try {
                _connection.Dispose();
            } catch (IOException ex) {
                throw ex;
            }
        }

        public bool TryConnect()
        {
            lock (sync_root) {
                var policy = RetryPolicy.Handle<SocketException>()
                    .Or<BrokerUnreachableException>()
                    .WaitAndRetry(_retryCount, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)), (ex, time) => { }
                );
                policy.Execute(() => {
                    _connection = _connectionFactory
                          .CreateConnection();
                });

                if (IsConnected) {
                    _connection.ConnectionShutdown += OnConnectionShutdown;
                    _connection.CallbackException += OnCallbackException;
                    _connection.ConnectionBlocked += OnConnectionBlocked;
                    return true;
                } else {
                    return false;
                }
            }
        }

        private void OnConnectionBlocked(object sender, ConnectionBlockedEventArgs e)
        {
            if (_disposed) return;
            TryConnect();
        }

        void OnCallbackException(object sender, CallbackExceptionEventArgs e)
        {
            if (_disposed) return;
            TryConnect();
        }

        void OnConnectionShutdown(object sender, ShutdownEventArgs reason)
        {
            if (_disposed) return;
            TryConnect();
        }


    }
}
