using FeriaVirtual.Domain.SeedWork.Query;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace FeriaVirtual.Infrastructure.SeedWork.Queries
{
    public class InMemoryQueryBus
        : IQueryBus
    {
        private static readonly ConcurrentDictionary<Type, object> _queryHandlers = new();
        private readonly IServiceProvider _provider;


        public InMemoryQueryBus(IServiceProvider provider) =>
            _provider = provider;


        public TResponse Ask<TResponse>(Query query)
        {
            var handler = GetWrappedHandlers<TResponse>(query);
            return handler is null
                ? throw new QueryNotRegisteredException(query)
                : handler.Handle(query, _provider);
        }


        private QueryHandlerWrapper<TResponse> GetWrappedHandlers<TResponse>(Query query)
        {
            Type[] typeArgs = { query.GetType(), typeof(TResponse) };
            var handlerType = typeof(IQueryHandler<,>).MakeGenericType(typeArgs);
            var wrapperType = typeof(QueryHandlerWrapper<,>).MakeGenericType(typeArgs);
            var handlers = (IEnumerable<Object>)_provider.GetService(typeof(IEnumerable<>).MakeGenericType(handlerType));
            var wrappedHandlers = (QueryHandlerWrapper<TResponse>)_queryHandlers.GetOrAdd(query.GetType(),
                handlers.Cast<object>()
                    .Select(handler => (QueryHandlerWrapper<TResponse>)Activator.CreateInstance(wrapperType))
                    .FirstOrDefault());
            return wrappedHandlers;
        }


    }
}
