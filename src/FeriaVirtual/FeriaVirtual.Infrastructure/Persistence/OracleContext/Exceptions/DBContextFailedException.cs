using System;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Exceptions
{
    public class DBContextFailedException
        : Exception
    {
        public DBContextFailedException(string message)
            : base(message) { }


    }
}
