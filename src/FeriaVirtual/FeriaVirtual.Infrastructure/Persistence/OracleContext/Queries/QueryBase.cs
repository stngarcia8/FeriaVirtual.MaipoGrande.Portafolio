using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    public abstract class QueryBase
    {
        protected IDBContext _dbContext;
        protected OracleCommand _command;

        protected QueryBase(IDBContext dbContext)
        {
            _dbContext = dbContext;
            ConfigureCommand();
        }

        private void ConfigureCommand()
        {
            _command = _dbContext.GetDBContext.CreateCommand();
            _command.Transaction = _dbContext.GetDBContextTransaction;
            _command.BindByName = true;
        }

        protected void AddParameter(string parameterName, object parameterValue, DbType parameterType)
        {
            _command.Parameters.Add(new OracleParameter {
                ParameterName = parameterName,
                Value = parameterValue,
                DbType = parameterType
            });
        }

        protected void ClearParameters() =>
            _command.Parameters.Clear();


    }
}
