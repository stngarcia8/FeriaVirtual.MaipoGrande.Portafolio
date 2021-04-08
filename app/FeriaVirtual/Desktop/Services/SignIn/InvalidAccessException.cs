using System;

namespace FeriaVirtual.App.Desktop.Services.SignIn
{
    public class InvalidAccessException
        : Exception
    {
        public InvalidAccessException(string message)
            : base(message) { }


    }
}
