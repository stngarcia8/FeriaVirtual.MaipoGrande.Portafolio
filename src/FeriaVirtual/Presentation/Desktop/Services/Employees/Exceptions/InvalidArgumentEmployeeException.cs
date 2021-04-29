using System;

namespace FeriaVirtual.App.Desktop.Services.Employees.Exceptions
{
    class InvalidArgumentEmployeeException
        : SystemException
    {
        public InvalidArgumentEmployeeException(string message)
            : base(message) { }


    }
}
