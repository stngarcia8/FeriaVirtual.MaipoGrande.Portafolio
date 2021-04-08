using System;

namespace FeriaVirtual.Application.Services.Signin
{
    public class InvalidSigninServiceException
        : Exception
    {
        public InvalidSigninServiceException(string message)
            : base(message) { }


    }
}
