using System;

namespace FeriaVirtual.Domain.SeedWork.Commands
{
    public abstract class CommandHandlerWrapper
    {
        public abstract void Handle
            (Command command, IServiceProvider provider);


    }


    public  class CommandHandlerWrapper<TCommand>
        : CommandHandlerWrapper
        where TCommand : Command
    {
        public override void Handle(Command command, IServiceProvider provider)
        {
            var handler = (ICommandHandler<TCommand>)provider.GetService(typeof(ICommandHandler<TCommand>));
            handler.Handle((TCommand)command);
        }



    }

}
