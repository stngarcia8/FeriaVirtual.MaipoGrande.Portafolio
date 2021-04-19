using FeriaVirtual.Domain.SeedWork.Commands;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeriaVirtual.Infrastructure.SeedWork.Commands
{
    public class InMemoryCommandBus
        : ICommandBus
    {
        private static readonly ConcurrentDictionary<System.Type, IEnumerable<CommandHandlerWrapper>> _commandHandlers =
            new();
        private readonly System.IServiceProvider _provider;

        public InMemoryCommandBus(System.IServiceProvider provider) =>
            _provider = provider;


        public async Task DispatchAsync(Command command)
        {
            var wrappedHandlers = GetWrappedHandlers(command);
            if(wrappedHandlers == null)
                throw new CommandNotRegisteredException(command);
            foreach(var handler in wrappedHandlers)
                await handler.Handle(command, _provider);
        }


        private IEnumerable<CommandHandlerWrapper> GetWrappedHandlers(Command command)
        {
            var handlerType = typeof(ICommandHandler<>).MakeGenericType(command.GetType());
            var wrapperType = typeof(CommandHandlerWrapper<>).MakeGenericType(command.GetType());
            var handlers =
                (IEnumerable<System.Object>)_provider.GetService(typeof(IEnumerable<>).MakeGenericType(handlerType));
            var wrappedHandlers = _commandHandlers.GetOrAdd(command.GetType(), handlers.Cast<object>()
                .Select(handler => (CommandHandlerWrapper)System.Activator.CreateInstance(wrapperType)));
            return wrappedHandlers;
        }


    }
}
