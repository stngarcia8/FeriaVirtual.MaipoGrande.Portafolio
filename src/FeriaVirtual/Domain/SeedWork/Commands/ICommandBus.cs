namespace FeriaVirtual.Domain.SeedWork.Commands
{
    public interface ICommandBus
    {
        void Dispatch(Command command);


    }
}
