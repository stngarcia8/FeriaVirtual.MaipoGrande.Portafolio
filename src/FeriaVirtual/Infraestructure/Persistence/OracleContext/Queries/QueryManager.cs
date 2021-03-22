using FeriaVirtual.Domain.SeedWork;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    sealed class QueryManager
    {
        private readonly OracleConnection _connection;
        private readonly OracleTransaction _transaction;
        private OracleCommand _command;


        private QueryManager
            (OracleConnection connection, OracleTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
            ConfigureCommand();
        }


        private void ConfigureCommand()
        {
            _command = _connection.CreateCommand();
            _command.Transaction = _transaction;
            _command.BindByName = true;
        }

        public static QueryManager BuildManager
            (OracleConnection connection, OracleTransaction transaction) =>
            new(connection, transaction);

        public void ExecuteStoredProcedure<TEntity>
            (string spName, TEntity entity)
            where TEntity : EntityBase
        {
            var spExcecutor = StoredProcedureQuery.BuildQuery(_command);
            spExcecutor.Excecute(spName, entity);
        }

        public void ExecuteStoredProcedure
            (string spName, Dictionary<string, object> parameters = null)
        {
            var spExcecutor = StoredProcedureQuery.BuildQuery(_command);
            spExcecutor.Excecute(spName, parameters);
        }

        public TResult ExecuteQuery<TResult>
            (string sqlStatement)
        {
            var queryExcecutor = SelectionQuery.BuildQuery(_command);
            return queryExcecutor.ExecuteQuery<TResult>(sqlStatement);
        }

        public IEnumerable<TViewModel> ExecuteQuery<TViewModel>
            (string sqlStatement, Dictionary<string, object> parameters = null)
            where TViewModel : IViewModelBase
        {
            var queryExcecutor = SelectionQuery.BuildQuery(_command);
            return queryExcecutor.ExecuteQuery<TViewModel>(sqlStatement, parameters);
        }






    }
}
