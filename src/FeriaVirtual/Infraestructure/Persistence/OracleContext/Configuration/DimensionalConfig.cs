namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration
{
    sealed class DimensionalConfig
        : DBConfig, IDBConfig
    {
        public string GetConnectionString { get; }
        public string GetDatabaseName { get; }


        private DimensionalConfig()
            : base()
        {
            GetConnectionString = GetDimensionalConnectionString;
            GetDatabaseName = this.GetType().Name;
        }


        public static IDBConfig Build() =>
            new DimensionalConfig();


    }
}
