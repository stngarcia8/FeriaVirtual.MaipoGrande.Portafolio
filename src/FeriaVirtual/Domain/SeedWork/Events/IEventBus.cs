using System.Threading.Tasks;

namespace FeriaVirtual.Domain.SeedWork.Events
{
    public interface IEventBus
    {
        Task PublishAsync(DomainEventCollection eventCollection);


    }
}
