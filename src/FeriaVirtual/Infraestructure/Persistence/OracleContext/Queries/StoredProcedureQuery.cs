using FeriaVirtual.Domain.SeedWork;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    class StoredProcedureQuery
        : QueryParameter
    {
        private StoredProcedureQuery(OracleCommand command)
            : base(command) { }

        public static StoredProcedureQuery BuildQuery(OracleCommand command) =>
            new(command);

        public void Excecute<TEntity>
            (string spName, TEntity entity)
            where TEntity : EntityBase
        {
            try {
                if (string.IsNullOrWhiteSpace(spName)) {
                    throw new QueryExecutorFailedException("No ha especificado un nombre de procedimiento almacenado para ejecutar.");
                }
                ConfigureCommand(spName);
                if (entity.GetPrimitives() != null) CreateStoredProcedureParameters(entity);
                _command.ExecuteNonQuery();
            } catch (Exception ex) {
                string message = $"Error al intentar ejecutar procedimiento almacenado {spName}, comunique este problema al administrador del sistema.{Environment.NewLine}Error: {ex.Message}";
                throw new QueryExecutorFailedException(message);
            }
        }

        public void Excecute
            (string spName, Dictionary<string, object> parameters = null)
        {
            try {
                if (string.IsNullOrWhiteSpace(spName)) {
                    throw new QueryExecutorFailedException("No ha especificado un nombre de procedimiento almacenado para ejecutar.");
                }
                ConfigureCommand(spName);
                if (parameters != null) CreateQueryParameters(parameters);
                _command.ExecuteNonQuery();
            } catch (Exception ex) {
                string message = $"Error al intentar ejecutar procedimiento almacenado {spName}, comunique este problema al administrador del sistema.{Environment.NewLine}Error: {ex.Message}";
                throw new QueryExecutorFailedException(message);
            }
        }

        private void ConfigureCommand(string spName)
        {
            ClearParameters();
            _command.CommandType = System.Data.CommandType.StoredProcedure;
            _command.CommandText = spName;
        }


    }
}
