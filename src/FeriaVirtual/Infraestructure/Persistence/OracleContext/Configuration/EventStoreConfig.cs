namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration
{
    sealed class EventStoreConfig
        : DBConfig, IDBConfig
    {
        public string GetConnectionString { get; }
        public string GetDatabaseName { get; }


        private EventStoreConfig()
            : base()
        {
            GetConnectionString = GetEventStoreConnectionString;
            GetDatabaseName = this.GetType().Name;
        }



        public static IDBConfig Build() =>
            new EventStoreConfig();


    }
}
