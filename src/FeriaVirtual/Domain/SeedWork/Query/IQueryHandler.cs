using System.Threading.Tasks;

namespace FeriaVirtual.Domain.SeedWork.Query
{
    public interface IQueryHandler<TQuery, TResponse>
        where TQuery : Query
    {
        Task<TResponse> Handle(TQuery query);


    }
}
