using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Domain.SeedWork.Events
{
    public interface  IEventSuscriber
    {
        void Dispatch(DomainEventBase domainEvent);


    }
}
