using System;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Exceptions
{
    public class StoredProcedureFailedException
        : Exception
    {
        public StoredProcedureFailedException(string message)
            : base(message) { }


    }
}
