using System;

namespace FeriaVirtual.Application.Users.Services
{
    public class InvalidUserServiceException
        : Exception
    {
        public InvalidUserServiceException(string message)
            : base(message) { }


    }
}
