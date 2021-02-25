using System.Collections.Generic;
using System.Data;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    interface ISelectionQuery
    {
        void AddParameter(string parameterName, object parameterValue, DbType parameterType);
        void ClearParameters();
        IEnumerable<TViewModel> ExecuteQuery<TViewModel>(string sqlStatement) where TViewModel : class;
        TViewModel ExecuteSingleQuery<TViewModel>(string sqlStatement) where TViewModel : class;


    }
}