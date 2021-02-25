namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration
{
    sealed class DimensionalConfig
        : DBConfig, IDBConfig
    {
        public string GetConnectionString { get; }


        private DimensionalConfig()
            : base() => GetConnectionString = GetDimensionalConnectionString;

        public static IDBConfig Build() =>
            new DimensionalConfig();


    }
}
