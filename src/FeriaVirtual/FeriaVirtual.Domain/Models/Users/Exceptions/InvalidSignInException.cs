using System;

namespace FeriaVirtual.Domain.Models.Users.Exceptions
{
    public class InvalidSignInException
        : Exception
    {
        public InvalidSignInException(string message)
            : base(message) { }


    }
}
