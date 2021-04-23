using FeriaVirtual.Domain.SeedWork;
using FeriaVirtual.Domain.SeedWork.Query;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeriaVirtual.Infrastructure.SeedWork
{
    public interface IContextManager
    {
        Task OpenContextAsync();

        Task SaveByStoredProcedureAsync<TEntity>
            (string storedProcedureName, TEntity entity)
            where TEntity : EntityBase;

        Task SaveByStoredProcedureAsync
            (string storedProcedureName, Dictionary<string, object> parameters);

        Task<IEnumerable<TResponse>> SelectAsync<TResponse>
            (string sqlStatement, Dictionary<string, object> parameters = null)
            where TResponse : IQueryResponseBase;

        Task<int> CountAsync(string sqlStatement);

        Task CommitInContextAsync();

        Task RollbackInContextAsync();

        Task CloseContextAsync();


    }
}
