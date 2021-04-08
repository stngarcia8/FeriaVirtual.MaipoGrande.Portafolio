using System;

namespace FeriaVirtual.Application.Services.Employees
{
    public class InvalidEmployeeServiceException
        : Exception
    {
        public InvalidEmployeeServiceException(string message)
            : base(message) { }


    }
}
