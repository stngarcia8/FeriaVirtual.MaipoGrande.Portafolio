using System;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext
{
    public class DBContextFailedException
        : Exception
    {
        public DBContextFailedException(string message)
            : base(message) { }


    }
}
