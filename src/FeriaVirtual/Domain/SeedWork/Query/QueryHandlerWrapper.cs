using System;

namespace FeriaVirtual.Domain.SeedWork.Query
{
    public abstract class QueryHandlerWrapper<TResponse>
    {
        public abstract TResponse Handle(Query query, IServiceProvider provider);


    }


    public class QueryHandlerWrapper<TQuery, TResponse>
        : QueryHandlerWrapper<TResponse>
        where TQuery : Query
    {
        public override TResponse Handle(Query query, IServiceProvider provider)
        {
            var handler = (IQueryHandler<TQuery, TResponse>)provider.GetService(typeof(IQueryHandler<TQuery, TResponse>));
            return handler.Handle((TQuery)query);
        }



    }

}
