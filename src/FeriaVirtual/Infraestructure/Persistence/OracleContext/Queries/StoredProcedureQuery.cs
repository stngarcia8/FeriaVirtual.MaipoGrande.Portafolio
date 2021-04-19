using FeriaVirtual.Domain.SeedWork;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    class StoredProcedureQuery
        : QueryParameter
    {
        private StoredProcedureQuery(OracleCommand command)
            : base(command) { }


        public static StoredProcedureQuery BuildQuery(OracleCommand command) =>
            new(command);


        public async Task ExcecuteAsync<TEntity>
            (string spName, TEntity entity)
            where TEntity : EntityBase
        {
            if(string.IsNullOrWhiteSpace(spName)) {
                throw new QueryExecutorFailedException("No ha especificado un nombre de procedimiento almacenado para ejecutar.");
            }
            ConfigureCommand(spName);
            if(entity.GetPrimitives() != null)
                CreateStoredProcedureParameters(entity);
            await _command.ExecuteNonQueryAsync();
        }


        public async Task ExcecuteAsync
            (string spName, Dictionary<string, object> parameters = null)
        {
            if(string.IsNullOrWhiteSpace(spName)) {
                throw new QueryExecutorFailedException("No ha especificado un nombre de procedimiento almacenado para ejecutar.");
            }
            ConfigureCommand(spName);
            if(parameters != null)
                CreateQueryParameters(parameters);
            await _command.ExecuteNonQueryAsync();
        }


        private void ConfigureCommand(string spName)
        {
            ClearParameters();
            _command.CommandType = System.Data.CommandType.StoredProcedure;
            _command.CommandText = spName;
        }


    }
}
