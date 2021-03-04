using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using FeriaVirtual.Domain.SeedWork;
using Oracle.ManagedDataAccess.Client;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    class StoredProcedureQuery
        : QueryParameter
    {
        private StoredProcedureQuery(OracleCommand command)
            : base(command) { }

        public static StoredProcedureQuery BuildQuery(OracleCommand command) =>
            new StoredProcedureQuery(command);

        public void  Excecute<TEntity>
            (string spName, TEntity entity)
            where TEntity : EntityBase
        {
            try {
                if (string.IsNullOrWhiteSpace(spName)) {
                    throw new QueryExecutorFailedException("No ha especificado un nombre de procedimiento almacenado para ejecutar.");
                }
                this.ClearParameters();
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.CommandText = spName;
                if (entity.GetPrimitives() != null) CreateStoredProcedureParameters(entity);
                _command.ExecuteNonQuery();
            } catch (Exception ex) {
                string message = $"Error al intentar ejecutar procedimiento almacenado {spName}, comunique este problema al administrador del sistema.{Environment.NewLine}Error: {ex.Message}";
                throw new QueryExecutorFailedException(message);
            }
        }

        private void CreateStoredProcedureParameters<TEntity>(TEntity entity)
            where TEntity : EntityBase
        {
            foreach (KeyValuePair<string, object> primitive in entity.GetPrimitives()) {
                this.AddParameter($"p{primitive.Key}", primitive.Value, GetFieldDbType(primitive.Value));
            }
        }

        private DbType GetFieldDbType(Object value)
        {
            Type obj = value.GetType();
            return obj.Name switch {
                "DateTime" => DbType.Date,
                "float" => DbType.Double,
                "Int32" => DbType.Int32,
                _ => DbType.String,
            };
        }

        public void Excecute
            (string spName, Dictionary<string, object> parameters = null)
        {
            try {
                if (string.IsNullOrWhiteSpace(spName)) {
                    throw new QueryExecutorFailedException("No ha especificado un nombre de procedimiento almacenado para ejecutar.");
                }
                this.ClearParameters();
                _command.CommandType = System.Data.CommandType.StoredProcedure;
                _command.CommandText = spName;
                if(parameters!=null) CreateStoredProcedureParameters(parameters);
                _command.ExecuteNonQuery();
            } catch (Exception ex) {
                string message = $"Error al intentar ejecutar procedimiento almacenado {spName}, comunique este problema al administrador del sistema.{Environment.NewLine}Error: {ex.Message}";
                throw new QueryExecutorFailedException(message);
            }
        }

        private void CreateStoredProcedureParameters(Dictionary<string, object> parameters)
        {
            foreach (KeyValuePair<string, object> parameter in parameters) {
                this.AddParameter($"p{parameter.Key}", parameter.Value, GetFieldDbType(parameter.Value));
            }
        }




    }
}
