using FeriaVirtual.Domain.SeedWork;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    abstract class QueryParameter
    {
        protected OracleCommand _command;

        public QueryParameter(OracleCommand command) =>
            _command = command;

        protected void AddParameter(string parameterName, object parameterValue, DbType parameterType)
        {
            _command.Parameters.Add(new OracleParameter
            {
                ParameterName = parameterName,
                Value = parameterValue,
                DbType = parameterType
            });
        }

        public void AddResultsParameter()
        {
            _command.Parameters.Add(new OracleParameter
            {
                ParameterName = "pResults",
                OracleDbType = OracleDbType.RefCursor,
                Direction = ParameterDirection.Output
            });
        }

        protected void ClearParameters() =>
            _command.Parameters.Clear();

        public void CreateStoredProcedureParameters<TEntity>(TEntity entity)
            where TEntity : EntityBase
        {
            foreach (KeyValuePair<string, object> primitive in entity.GetPrimitives()) {
                this.AddParameter($"p{primitive.Key}", primitive.Value, GetFieldDbType(primitive.Value));
            }
        }

        public void CreateQueryParameters(Dictionary<string, object> parameters)
        {
            foreach (KeyValuePair<string, object> parameter in parameters) {
                this.AddParameter($"p{parameter.Key}", parameter.Value, GetFieldDbType(parameter.Value));
            }
        }

        public static DbType GetFieldDbType(object value)
        {
            Type obj = value.GetType();
            return obj.Name switch
            {
                "DateTime" => DbType.Date,
                "float" => DbType.Double,
                "Int32" => DbType.Int32,
                _ => DbType.String,
            };
        }



    }
}
