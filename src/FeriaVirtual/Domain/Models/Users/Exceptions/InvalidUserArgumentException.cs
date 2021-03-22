using System;

namespace FeriaVirtual.Domain.Models.Users.Exceptions
{
    public class InvalidUserArgumentException
        : Exception
    {
        public InvalidUserArgumentException(string message)
            : base(message) { }


    }
}
