namespace FeriaVirtual.Domain.SeedWork.Events
{
    public interface IDomainEventDeserializer
    {
        DomainEventBase Deserialize(string domainEvent);


    }
}
