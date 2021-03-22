using Oracle.ManagedDataAccess.Client;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.RegionalInfo
{
    public interface IDBContextRegionalInfo
    {
        OracleGlobalization GetConfigurationInfo { get; }


    }
}
