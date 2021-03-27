namespace FeriaVirtual.Domain.SeedWork.Query
{
    public interface IQueryBus
    {
        TResponse Ask<TResponse>(Query request);


    }
}
