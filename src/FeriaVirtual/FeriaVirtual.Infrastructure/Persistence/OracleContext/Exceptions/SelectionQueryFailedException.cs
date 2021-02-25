using System;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Exceptions
{
    public class SelectionQueryFailedException
        : Exception
    {
        public SelectionQueryFailedException(string message)
            : base(message) { }


    }
}
