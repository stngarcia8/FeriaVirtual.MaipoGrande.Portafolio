using FeriaVirtual.Domain.SeedWork.Commands;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Infrastructure.SeedWork.Commands
{
    public class InMemoryCommandBus
        :ICommandBus
    {
        private static readonly ConcurrentDictionary<Type, IEnumerable<CommandHandlerWrapper>> _commandHandlers =
            new();
        private readonly IServiceProvider _provider;

        public InMemoryCommandBus(IServiceProvider provider) =>
            _provider = provider;


        public void Dispatch(Command command)
        {
            var wrappedHandlers = GetWrappedHandlers(command);
            if (wrappedHandlers == null) 
                throw new CommandNotRegisteredException(command);
            foreach (var handler in wrappedHandlers) 
                handler.Handle(command, _provider);
        }



        private IEnumerable<CommandHandlerWrapper> GetWrappedHandlers(Command command)
        {
            var handlerType = typeof(ICommandHandler<>).MakeGenericType(command.GetType());
            var wrapperType = typeof(CommandHandlerWrapper<>).MakeGenericType(command.GetType());
            var handlers =
                (IEnumerable<Object>)_provider.GetService(typeof(IEnumerable<>).MakeGenericType(handlerType));
            var wrappedHandlers = _commandHandlers.GetOrAdd(command.GetType(), handlers.Cast<object>()
                .Select(handler => (CommandHandlerWrapper)Activator.CreateInstance(wrapperType)));
            return wrappedHandlers;
        }




    }
}
