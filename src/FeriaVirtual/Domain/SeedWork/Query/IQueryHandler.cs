namespace FeriaVirtual.Domain.SeedWork.Query
{
    public interface IQueryHandler<TQuery, TResponse>
        where TQuery : Query
    {
        TResponse Handle(TQuery query);


    }
}
