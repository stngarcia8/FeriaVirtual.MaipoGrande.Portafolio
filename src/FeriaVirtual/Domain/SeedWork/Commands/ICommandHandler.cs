namespace FeriaVirtual.Domain.SeedWork.Commands
{
    public interface ICommandHandler<TCommand>
        where TCommand : Command
    {
        void Handle(TCommand command);


    }
}
