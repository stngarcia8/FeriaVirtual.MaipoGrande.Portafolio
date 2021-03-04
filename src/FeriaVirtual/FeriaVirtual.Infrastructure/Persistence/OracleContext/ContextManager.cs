﻿using System;
using System.Collections.Generic;
using FeriaVirtual.Domain.SeedWork;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.RegionalInfo;
using Oracle.ManagedDataAccess.Client;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext
{
    public sealed class ContextManager
        : IDisposable, IContextManager
    {
        private bool _disposed;
        private readonly IDBConfig _dbConfig;
        private OracleConnection _connection;
        private OracleTransaction _transaction;


        private ContextManager(IDBConfig dbConfig) =>
            _dbConfig = dbConfig;

        public static ContextManager BuildContext(IDBConfig dbConfig) =>
            new ContextManager(dbConfig);

        public void OpenContext()
        {
            try {
                _connection = new OracleConnection(_dbConfig.GetConnectionString);
                if (_connection.State != System.Data.ConnectionState.Open) _connection.Open();
                if (_connection.State == System.Data.ConnectionState.Open) {
                    var regionalInfo = DBContextRegionalInfo.BuildRegionalInfo(_connection.GetSessionInfo());
                    _connection.SetSessionInfo(regionalInfo.GetConfigurationInfo);
                    _transaction = _connection.BeginTransaction();
                }
            } catch (Exception ex) {
                string message = $"No ha sido posible establecer conexión con el servidor de base de datos, comunique este problema al administrador del sistema.{Environment.NewLine}Error: {ex.Message}";
                throw new DBContextFailedException(message);
            }
        }


        public void SaveByStoredProcedure<TEntity>
            (string storedProcedureName, TEntity entity)
            where TEntity : EntityBase
        {
            var qm = QueryManager.BuildManager(_connection, _transaction);
            qm.ExecuteStoredProcedure<TEntity>(storedProcedureName, entity);
        }

        public void SaveByStoredProcedure
            (string storedProcedureName, Dictionary<string, object> parameters=null)
        {
            var qm = QueryManager.BuildManager(_connection, _transaction);
            qm.ExecuteStoredProcedure(storedProcedureName, parameters);
        }

        public void CommitInContext()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
                _transaction.Commit();
        }

        public void RollbackInContext()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
                _transaction.Rollback();
        }

        public void CloseContext()
        {
            if (_connection.State == System.Data.ConnectionState.Open) {
                _transaction.Dispose();
                _connection.Close();
            }
        }



        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing) {
                //CloseContextTransaction();
                //CloseContext();
            }
            _disposed = true;
        }

        ~ContextManager()
        {
            Dispose(false);
        }


    }
}