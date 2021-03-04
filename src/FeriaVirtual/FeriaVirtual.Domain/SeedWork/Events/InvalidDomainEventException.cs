using System;
using System.Collections.Generic;
using System.Text;

namespace FeriaVirtual.Domain.SeedWork.Events
{
    public class InvalidDomainEventException
        :Exception
    {
        public InvalidDomainEventException(string message)
            :base(message) { }


    }
}
