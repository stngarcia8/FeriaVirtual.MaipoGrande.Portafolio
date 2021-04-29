using FeriaVirtual.Domain.SeedWork;
using FeriaVirtual.Domain.SeedWork.Query;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Threading.Tasks;

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
            if(_connection.State != System.Data.ConnectionState.Open)
                throw new DBContextFailedException("No ha sido posible conectarse a la base de datos");
            _command = _connection.CreateCommand();
            _command.Transaction = _transaction;
            _command.BindByName = true;
        }


        public static QueryManager BuildManager
            (OracleConnection connection, OracleTransaction transaction) =>
            new(connection, transaction);


        public async Task ExecuteStoredProcedureAsync<TEntity>
            (string spName, TEntity entity)
            where TEntity : EntityBase
        {
            var spExcecutor = StoredProcedureQuery.BuildQuery(_command);
            await spExcecutor.ExcecuteAsync(spName, entity);
        }


        public async Task ExecuteStoredProcedureAsync
            (string spName, Dictionary<string, object> parameters = null)
        {
            var spExcecutor = StoredProcedureQuery.BuildQuery(_command);
            await spExcecutor.ExcecuteAsync(spName, parameters);
        }


        public async Task<TResponse> ExecuteSingleQueryAsync<TResponse>
            (string sqlStatement, Dictionary<string, object> parameters = null)
        {
            var queryExcecutor = SelectionQuery.BuildQuery(_command);
            return await queryExcecutor.ExecuteSingleQueryAsync<TResponse>(sqlStatement, parameters);
        }


        public async Task<IEnumerable<TResponse>> ExecuteQueryAsync<TResponse>
            (string sqlStatement, Dictionary<string, object> parameters = null)
            where TResponse : IQueryResponseBase
        {
            var queryExcecutor = SelectionQuery.BuildQuery(_command);
            return await queryExcecutor.ExecuteQueryAsync<TResponse>(sqlStatement, parameters);
        }


    }
}
