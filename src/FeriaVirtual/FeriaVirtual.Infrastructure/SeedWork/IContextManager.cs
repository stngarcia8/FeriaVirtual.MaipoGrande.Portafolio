using System.Collections.Generic;
using FeriaVirtual.Domain.SeedWork;

namespace FeriaVirtual.Infrastructure.SeedWork
{
    public interface IContextManager
    {
        void OpenContext();

        void SaveByStoredProcedure<TEntity>
            (string storedProcedureName, TEntity entity)
            where TEntity : EntityBase;

        void SaveByStoredProcedure
            (string storedProcedureName, Dictionary<string, object> parameters);

        IEnumerable<TViewModel> Select<TViewModel>
            (string sqlStatement, Dictionary<string, object> parameters = null)
            where TViewModel : IViewModelBase;

        int Count(string sqlStatement);

        void CommitInContext();

        void RollbackInContext();

        void CloseContext();


    }
}
