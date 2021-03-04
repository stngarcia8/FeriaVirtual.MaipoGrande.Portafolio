using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeriaVirtual.Domain.SeedWork.Events
{
    public interface IEventPublisher
    {
        void  Publish(IList<DomainEventBase> domainEvents);


    }
}
