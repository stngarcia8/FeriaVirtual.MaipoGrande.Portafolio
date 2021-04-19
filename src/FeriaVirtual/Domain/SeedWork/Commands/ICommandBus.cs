using System.Threading.Tasks;

namespace FeriaVirtual.Domain.SeedWork.Commands
{
    public interface ICommandBus
    {
        Task DispatchAsync(Command command);


    }
}
