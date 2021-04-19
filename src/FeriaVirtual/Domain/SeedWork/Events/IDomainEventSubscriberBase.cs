using System.Threading.Tasks;

namespace FeriaVirtual.Domain.SeedWork.Events
{
    public interface IDomainEventSubscriberBase
    {
        Task On(DomainEventBase @event);


    }
}
