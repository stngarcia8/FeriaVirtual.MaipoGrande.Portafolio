using System;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext
{
    class DBContextFailedException
        : Exception
    {
        public DBContextFailedException(string message)
            :base(message){ }


    }
}
