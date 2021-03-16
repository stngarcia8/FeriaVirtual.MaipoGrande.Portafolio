using System;

namespace FeriaVirtual.Domain.SeedWork.Events
{
    public class InvalidDomainEventException
        : Exception
    {
        public InvalidDomainEventException(string message)
            : base(message) { }


    }
}
