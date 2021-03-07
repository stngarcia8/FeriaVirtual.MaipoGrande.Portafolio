using System.Collections.Generic;
using FeriaVirtual.Domain.SeedWork;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext
{
    public interface IContextManager
    {
        void OpenContext();

        void SaveByStoredProcedure<TEntity>
            (string storedProcedureName, TEntity entity)
            where TEntity : EntityBase;

        void SaveByStoredProcedure
            (string storedProcedureName, Dictionary<string, object> parameters);

        IList<TViewModel> Select<TViewModel>
            (string sqlStatement, Dictionary<string, object> parameters = null)
            where TViewModel : IViewModelBase;

        void CommitInContext();

        void RollbackInContext();

        void CloseContext();


    }
}
