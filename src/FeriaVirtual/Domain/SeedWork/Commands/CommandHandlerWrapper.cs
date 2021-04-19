using System;
using System.Threading.Tasks;

namespace FeriaVirtual.Domain.SeedWork.Commands
{
    public abstract class CommandHandlerWrapper
    {
        public abstract Task Handle
            (Command command, IServiceProvider provider);


    }


    public class CommandHandlerWrapper<TCommand>
        : CommandHandlerWrapper
        where TCommand : Command
    {
        public override async Task Handle(Command command, IServiceProvider provider)
        {
            var handler = (ICommandHandler<TCommand>)provider.GetService(typeof(ICommandHandler<TCommand>));
            await handler.Handle((TCommand)command);
        }



    }

}
