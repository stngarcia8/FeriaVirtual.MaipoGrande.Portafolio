namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration
{
    sealed class EventStoreConfig
        : DBConfig, IDBConfig
    {
        public string GetConnectionString { get; }


        private EventStoreConfig()
            : base() => GetConnectionString = GetEventStoreConnectionString;

        public static IDBConfig Build() =>
            new EventStoreConfig();


    }
}
