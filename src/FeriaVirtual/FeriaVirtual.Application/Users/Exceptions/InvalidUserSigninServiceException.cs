using System;

namespace FeriaVirtual.Application.Users.Exceptions
{
    public class InvalidUserSigninServiceException
        : Exception
    {
        public InvalidUserSigninServiceException
            (string message)
            : base(message) { }


    }
}
