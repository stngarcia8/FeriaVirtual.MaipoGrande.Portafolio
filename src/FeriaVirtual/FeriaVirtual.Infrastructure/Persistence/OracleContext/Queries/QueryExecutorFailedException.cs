using System;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    class QueryExecutorFailedException
        : Exception
    {
        public QueryExecutorFailedException(string message)
            : base(message) { }


    }
}
