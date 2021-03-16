using System.Collections.Generic;

namespace FeriaVirtual.Domain.SeedWork.Events
{
    public interface IEventPublisher
    {
        void Publish(IList<DomainEventBase> domainEvents);


    }
}
