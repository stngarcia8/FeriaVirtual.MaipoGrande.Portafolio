namespace FeriaVirtual.Domain.SeedWork.Events
{
    public interface IEventDispatcher
    {
        void Dispatch(DomainEventBase domainEvent);


    }
}
