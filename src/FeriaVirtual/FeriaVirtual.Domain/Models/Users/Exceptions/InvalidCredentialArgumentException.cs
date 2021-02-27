using System;

namespace FeriaVirtual.Domain.Models.Users.Exceptions
{
    public class InvalidCredentialArgumentException
        : Exception
    {
        public InvalidCredentialArgumentException(string message)
            : base(message) { }


    }
}
