namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration
{
    public interface IDBConfig
    {
        string GetConnectionString { get; }
    }
}