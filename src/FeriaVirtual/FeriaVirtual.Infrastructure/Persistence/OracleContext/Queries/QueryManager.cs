﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using FeriaVirtual.Domain.SeedWork;
using Oracle.ManagedDataAccess.Client;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    sealed class QueryManager
    {
        private  readonly OracleConnection _connection;
        private  readonly OracleTransaction _transaction;
        private  OracleCommand _command;


        private QueryManager(OracleConnection connection, OracleTransaction transaction)
        {
            _connection= connection;
            _transaction= transaction;
            ConfigureCommand();
        }

        private void ConfigureCommand()
        {
            _command = _connection.CreateCommand();
            _command.Transaction = _transaction;
            _command.BindByName = true;
        }

        public static QueryManager BuildManager(OracleConnection connection, OracleTransaction transaction) =>
            new QueryManager(connection, transaction);

        public void ExecuteStoredProcedure<TEntity>
            (string spName, TEntity entity)
            where TEntity:EntityBase
        {
            var spExcecutor = StoredProcedureQuery.BuildQuery(_command);
            spExcecutor.Excecute(spName, entity);
        }

        public void ExecuteStoredProcedure
            (string spName, Dictionary<string, object> parameters=null)
        {
            var spExcecutor = StoredProcedureQuery.BuildQuery(_command);
            spExcecutor.Excecute(spName, parameters);
        }







    }
}