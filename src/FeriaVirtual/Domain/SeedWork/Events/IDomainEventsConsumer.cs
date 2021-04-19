using System.Threading.Tasks;

namespace FeriaVirtual.Domain.SeedWork.Events
{
    public interface IDomainEventsConsumer
    {
        Task Consume();



    }
}
