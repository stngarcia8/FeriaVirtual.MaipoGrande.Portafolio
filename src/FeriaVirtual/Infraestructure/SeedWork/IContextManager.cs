using FeriaVirtual.Domain.SeedWork;
using FeriaVirtual.Domain.SeedWork.Query;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeriaVirtual.Infrastructure.SeedWork
{
    public interface IContextManager
    {
        Task OpenContextAsync();

        Task SaveByStoredProcedure<TEntity>
            (string storedProcedureName, TEntity entity)
            where TEntity : EntityBase;

        Task SaveByStoredProcedure
            (string storedProcedureName, Dictionary<string, object> parameters);

        Task<IEnumerable<TResponse>> Select<TResponse>
            (string sqlStatement, Dictionary<string, object> parameters = null)
            where TResponse : IQueryResponseBase;

        Task<int> Count(string sqlStatement);

        Task CommitInContextAsync();

        Task RollbackInContextAsync();

        Task CloseContextAsync();


    }
}
