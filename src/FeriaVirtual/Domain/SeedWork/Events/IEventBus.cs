using System.Collections.Generic;

namespace FeriaVirtual.Domain.SeedWork.Events
{
    public interface IEventBus
    {
        void Publish(DomainEventCollection eventCollection);


    }
}
