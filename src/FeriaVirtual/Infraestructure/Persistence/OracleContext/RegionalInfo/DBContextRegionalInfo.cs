using Oracle.ManagedDataAccess.Client;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.RegionalInfo
{
    public sealed class DBContextRegionalInfo
        : IDBContextRegionalInfo
    {
        private readonly OracleGlobalization _configurationInfo;

        public OracleGlobalization GetConfigurationInfo => _configurationInfo;


        private DBContextRegionalInfo() { }

        private DBContextRegionalInfo(
            OracleGlobalization configurationInfo)
        {
            _configurationInfo = configurationInfo;
            InitializeConfigRegionalInfo();
        }

        public static DBContextRegionalInfo BuildRegionalInfo(
            OracleGlobalization configurationInfo) =>
            new(configurationInfo);

        private void InitializeConfigRegionalInfo()
        {
            _configurationInfo.Language = "Spanish";
            _configurationInfo.Territory = "Spain";
            _configurationInfo.Currency = "$";
            _configurationInfo.ISOCurrency = "AMERICA";
            _configurationInfo.NumericCharacters = ".,";
            _configurationInfo.Calendar = "GREGORIAN";
            _configurationInfo.DateFormat = "DD-MON-RR";
            _configurationInfo.DateLanguage = "SPANISH";
            _configurationInfo.Sort = "BINARY";
        }


    }
}
