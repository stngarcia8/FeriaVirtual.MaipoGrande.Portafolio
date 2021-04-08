using System;

namespace FeriaVirtual.Application.Services.Users
{
    public class InvalidUserServiceException
        : Exception
    {
        public InvalidUserServiceException(string message)
            : base(message) { }


    }
}
