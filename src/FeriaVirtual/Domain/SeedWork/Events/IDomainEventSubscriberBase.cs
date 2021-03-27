namespace FeriaVirtual.Domain.SeedWork.Events
{
    public interface IDomainEventSubscriberBase
    {
        void On(DomainEventBase @event);


    }
}
