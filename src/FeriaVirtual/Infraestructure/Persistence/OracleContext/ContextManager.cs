using FeriaVirtual.Domain.SeedWork;
using FeriaVirtual.Domain.SeedWork.Query;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.RegionalInfo;
using FeriaVirtual.Infrastructure.SeedWork;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext
{
    public sealed class ContextManager
        : System.IDisposable, IContextManager
    {
        private bool _disposed;
        private readonly IDBConfig _dbConfig;
        private OracleConnection _connection;
        private OracleTransaction _transaction;


        private ContextManager(IDBConfig dbConfig) =>
            _dbConfig = dbConfig;


        public static ContextManager BuildContext(IDBConfig dbConfig) =>
            new(dbConfig);


        public async Task OpenContextAsync()
        {
            _connection = new OracleConnection(_dbConfig.GetConnectionString);
            await _connection.OpenAsync();
            _transaction = await Task.Run(() => _connection.BeginTransaction());
            if(_connection.State == System.Data.ConnectionState.Open) {
                var regionalInfo = DBContextRegionalInfo.BuildRegionalInfo(_connection.GetSessionInfo());
                _connection.SetSessionInfo(regionalInfo.GetConfigurationInfo);
            }

        }


        public async Task SaveByStoredProcedureAsync<TEntity>
            (string storedProcedureName, TEntity entity)
            where TEntity : EntityBase
        {
            var qm = QueryManager.BuildManager(_connection, _transaction);
            await qm.ExecuteStoredProcedureAsync<TEntity>(storedProcedureName, entity);
        }

        public async Task SaveByStoredProcedureAsync
            (string storedProcedureName, Dictionary<string, object> parameters = null)
        {
            var qm = QueryManager.BuildManager(_connection, _transaction);
            await qm.ExecuteStoredProcedureAsync(storedProcedureName, parameters);
        }

        public async Task<IEnumerable<TResponse>> SelectAsync<TResponse>
            (string sqlStatement, Dictionary<string, object> parameters = null)
            where TResponse : IQueryResponseBase
        {
            var qm = QueryManager.BuildManager(_connection, _transaction);
            return (IEnumerable<TResponse>)await qm.ExecuteQueryAsync<TResponse>(sqlStatement, parameters);
        }

        public async Task<int> CountAsync
            (string sqlStatement, Dictionary<string, object> parameters = null)
        {
            var qm = QueryManager.BuildManager(_connection, _transaction);
            return await qm.ExecuteSingleQueryAsync<int>(sqlStatement, parameters);
        }


        public async Task CommitInContextAsync()
        {
            if(_connection.State == System.Data.ConnectionState.Open)
                await _transaction.CommitAsync();
        }


        public async Task RollbackInContextAsync()
        {
            if(_connection.State == System.Data.ConnectionState.Open)
                await _transaction.RollbackAsync();
        }

        public async Task CloseContextAsync()
        {
            if(_connection.State == System.Data.ConnectionState.Open) {
                await _transaction.DisposeAsync();
                await _connection.CloseAsync();
            }
        }



        public void Dispose()
        {
            DisposeAsync(true);
            System.GC.SuppressFinalize(this);
        }

        public async void DisposeAsync(bool disposing)
        {
            if(_disposed)
                return;
            if(disposing) {
                await CloseContextAsync();
            }
            _disposed = true;
        }

        ~ContextManager()
        {
            DisposeAsync(false);
        }


    }
}
