using System;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Exceptions
{
    public class ActionQueryFailedException
        : Exception
    {
        public ActionQueryFailedException(string message)
            : base(message) { }


    }
}
