using System;
using System.Data;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Exceptions;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    sealed class ActionQuery
        : QueryBase, IActionQuery
    {
        private ActionQuery(IDBContext dbContext)
            : base(dbContext) =>
            _command.CommandType = CommandType.Text;

        public static IActionQuery BuildQuery(IDBContext dbContext) =>
            new ActionQuery(dbContext);

        public new void AddParameter(
            string parameterName, object parameterValue, DbType parameterType) =>
            base.AddParameter(parameterName, parameterValue, parameterType);

        public new void ClearParameters() =>
            base.ClearParameters();

        public int Execute(string sqlStatement)
        {
            int recordsAfected;
            try {
                if (string.IsNullOrWhiteSpace(sqlStatement)) {
                    throw new ActionQueryFailedException("Sentencia sql inválida, nula o vacía.");
                }
                _command.CommandText = sqlStatement;
                recordsAfected = _command.ExecuteNonQuery();
                return recordsAfected;
            } catch (Exception ex) {
                string message = $"Error al intentar ejecutar sentencia sql {sqlStatement}, comunique este problema al administrador del sistema.{Environment.NewLine}Error: {ex.Message}";
                throw new ActionQueryFailedException(message);
            }
        }


    }
}
