using System;
using System.Data;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Exceptions;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.RegionalInfo;
using Oracle.ManagedDataAccess.Client;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext
{
    public class DBContext
        : IDisposable, IDBContext
    {
        private bool _disposed = false;
        private readonly IDBConfig _dbConfig;
        private OracleConnection _oracleConnection;
        private OracleTransaction _oracleTransaction;

        public OracleConnection GetDBContext => _oracleConnection;
        public OracleTransaction GetDBContextTransaction => _oracleTransaction;


        private DBContext(IDBConfig dbConfig)
        {
            _dbConfig = dbConfig;
            InitializeObjects();
        }

        public static IDBContext BuildContext(IDBConfig dbConfig) =>
            new DBContext(dbConfig);

        private void InitializeObjects()
        {
            try {
                _oracleConnection = new OracleConnection(_dbConfig.GetConnectionString);
                if (_oracleConnection.State != ConnectionState.Open) {
                    _oracleConnection.Open();
                }
                _oracleConnection.SetSessionInfo(
                    ((IDBContextRegionalInfo)DBContextRegionalInfo.BuildRegionalInfo(
                        _oracleConnection.GetSessionInfo())).GetConfigurationInfo);
                _oracleTransaction = _oracleConnection.BeginTransaction();
            } catch (Exception ex) {
                string message = $"No ha sido posible establecer conexión con el servidor de base de datos, comunique este problema al administrador del sistema.{Environment.NewLine}Error: {ex.Message}";
                throw new DBContextFailedException(message);
            }
        }

        private void CloseContextTransaction() =>
            _oracleTransaction?.Dispose();

        private void CloseContext()
        {
            _oracleConnection?.Close();
            _oracleConnection?.Dispose();
        }

        public void CommitContext() =>
            _oracleTransaction?.Commit();

        public void RollbackContext() =>
            _oracleTransaction?.Rollback();



        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing) {
                CloseContextTransaction();
                CloseContext();
            }
            _disposed = true;
        }

        ~DBContext()
        {
            Dispose(false);
        }


    }
}
