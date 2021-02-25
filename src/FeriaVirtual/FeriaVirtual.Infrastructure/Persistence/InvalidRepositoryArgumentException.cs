using System;

namespace FeriaVirtual.Infrastructure.Persistence 
{
    class InvalidRepositoryArgumentException
        : Exception
    {
        public InvalidRepositoryArgumentException(string message)
            : base(message) { }


    }
}
