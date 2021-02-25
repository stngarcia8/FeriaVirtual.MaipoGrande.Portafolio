using System;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration
{
    public abstract class DBConfig
    {
        private readonly String _relational;
        private readonly String _dimensional;
        private readonly String _eventStore;

        protected String GetRelationalConnectionString => _relational;
        protected String GetDimensionalConnectionString => _dimensional;
        protected String GetEventStoreConnectionString => _eventStore;


        protected DBConfig()
        {
            var config = LoadConfiguration.Load().GetConfiguration;
            _relational = config["ConnectionStrings: RelationalSchema"];
            _dimensional = config["ConnectionStrings: DimensionalSchema"];
            _eventStore = config["ConnectionStrings: EventstoreSchema"];
        }


    }
}
