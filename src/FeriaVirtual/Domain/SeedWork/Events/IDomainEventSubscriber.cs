using System.Threading.Tasks;

namespace FeriaVirtual.Domain.SeedWork.Events
{
    public interface IDomainEventSubscriber<TDomain>
        : IDomainEventSubscriberBase
        where TDomain : DomainEventBase
    {
        async Task IDomainEventSubscriberBase.On(DomainEventBase @event)
        {
            var msg = @event as TDomain;
            if(msg is null)
                await On(msg);
        }


        Task On(TDomain domainEvent);


    }
}
