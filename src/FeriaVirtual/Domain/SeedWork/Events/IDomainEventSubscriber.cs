namespace FeriaVirtual.Domain.SeedWork.Events
{
    public interface IDomainEventSubscriber<TDomain>
        : IDomainEventSubscriberBase
        where TDomain : DomainEventBase
    {
        void IDomainEventSubscriberBase.On(DomainEventBase @event)
        {
            var msg = @event as TDomain;
            if (msg is null)
                On(msg);
        }


        void On(TDomain domainEvent);


    }
}
