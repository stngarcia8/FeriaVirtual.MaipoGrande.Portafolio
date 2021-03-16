using System;

namespace FeriaVirtual.Application.Users.Exceptions
{
    public class InvalidUserServiceException
        : Exception
    {
        public InvalidUserServiceException(string message)
            : base(message) { }


    }
}
