using System;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    public class QueryExecutorFailedException
        : Exception
    {
        public QueryExecutorFailedException(string message)
            : base(message) { }


    }
}
