namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration
{
    sealed class RelationalConfig
        : DBConfig, IDBConfig
    {
        public string GetConnectionString { get; }
        public string GetDatabaseName { get; }

        private RelationalConfig()
            : base()
        {
            GetConnectionString = GetRelationalConnectionString;
            GetDatabaseName = this.GetType().Name;
        }

        public static IDBConfig Build() =>
            new RelationalConfig();


    }
}
