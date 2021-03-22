namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration
{
    sealed class RelationalConfig
        : DBConfig, IDBConfig
    {
        public string GetConnectionString { get; }

        private RelationalConfig()
            : base() => 
            GetConnectionString = GetRelationalConnectionString;

        public static IDBConfig Build() =>
            new RelationalConfig();


    }
}
