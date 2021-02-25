using System.Data;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    interface IStoredProcedureQuery
    {
        void AddParameter(string parameterName, object parameterValue, DbType parameterType);
        void ClearParameters();
        void Execute(string storeProcedureName);


    }
}