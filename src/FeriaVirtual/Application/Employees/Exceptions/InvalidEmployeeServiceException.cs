using System;

namespace FeriaVirtual.Application.Employees.Exceptions
{
    public class InvalidEmployeeServiceException
        : Exception
    {
        public InvalidEmployeeServiceException(string message)
            : base(message) { }


    }
}
