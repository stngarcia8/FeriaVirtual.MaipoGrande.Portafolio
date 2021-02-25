using System.Data;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    interface IActionQuery
    {
        void AddParameter(string parameterName, object parameterValue, DbType parameterType);
        void ClearParameters();
        int Execute(string sqlStatement);


    }
}