using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Text;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    abstract class QueryParameter
    {
        protected OracleCommand _command;

        public QueryParameter(OracleCommand command) =>
            _command = command;

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
