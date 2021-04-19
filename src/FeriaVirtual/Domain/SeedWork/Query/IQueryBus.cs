using System.Threading.Tasks;

namespace FeriaVirtual.Domain.SeedWork.Query
{
    public interface IQueryBus
    {
        Task<TResponse> Ask<TResponse>(Query request);


    }
}
