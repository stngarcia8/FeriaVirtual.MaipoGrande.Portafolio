using System;

namespace FeriaVirtual.App.Desktop.Exceptions
{
    public class InvalidAccessException
        : Exception
    {
        public InvalidAccessException(string message)
            : base(message) { }


    }
}
