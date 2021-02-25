using System;
using System.Data;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Exceptions;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    class StoredProcedureQuery
        : QueryBase, IStoredProcedureQuery
    {
        private StoredProcedureQuery(IDBContext dbContext)
            : base(dbContext) =>
            _command.CommandType = CommandType.StoredProcedure;

        public static IStoredProcedureQuery BuildQuery(IDBContext dbContext) =>
            new StoredProcedureQuery(dbContext);

        public new void AddParameter(
            string parameterName, object parameterValue, DbType parameterType) =>
            base.AddParameter(parameterName, parameterValue, parameterType);

        public new void ClearParameters() =>
            base.ClearParameters();

        public void Execute(string storeProcedureName)
        {
            try {
                if (string.IsNullOrWhiteSpace(storeProcedureName)) {
                    throw new StoredProcedureFailedException("Nombre de procedimiento almacenado inválido, nulo o vacío.");
                }
                _command.CommandText = storeProcedureName;
                _command.ExecuteNonQuery();
            } catch (Exception ex) {
                string message = $"Error al intentar ejecutar procedimiento almacenado {storeProcedureName}, comunique este problema al administrador del sistema.{Environment.NewLine}Error: {ex.Message}";
                throw new StoredProcedureFailedException(message);
            }
        }


    }
}
