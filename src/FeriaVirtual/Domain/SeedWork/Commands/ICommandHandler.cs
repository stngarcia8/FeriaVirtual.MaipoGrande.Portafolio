using System.Threading.Tasks;

namespace FeriaVirtual.Domain.SeedWork.Commands
{
    public interface ICommandHandler<TCommand>
        where TCommand : Command
    {
        Task Handle(TCommand command);


    }
}
