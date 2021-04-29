using FeriaVirtual.Domain.SeedWork.Query;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    class SelectionQuery
        : QueryParameter
    {
        private SelectionQuery(OracleCommand command)
            : base(command) { }


        public static SelectionQuery BuildQuery(OracleCommand command) =>
            new(command);


        public async Task<TResponse> ExecuteSingleQueryAsync<TResponse>
            (string spName, Dictionary<string, object> parameters = null)
        {
            if(string.IsNullOrWhiteSpace(spName))
                throw new QueryExecutorFailedException("No ha especificado una consulta de selección para ejecutar.");

            ConfigureCommand(spName);
            if(parameters is not null )
                CreateQueryParameters(parameters);
            AddResultsParameter();
            return (TResponse)System.Convert.ChangeType(await _command.ExecuteScalarAsync(), typeof(TResponse));
        }


        public async Task<IEnumerable<TResponse>> ExecuteQueryAsync<TResponse>
            (string sqlStatement, Dictionary<string, object> parameters = null)
            where TResponse : IQueryResponseBase
        {
            if(string.IsNullOrWhiteSpace(sqlStatement)) {
                throw new QueryExecutorFailedException("No ha especificado una consulta de selección para ejecutar.");
            }
            ConfigureCommand(sqlStatement);

            if(parameters != null)
                CreateQueryParameters(parameters);
            AddResultsParameter();

            var resultType = typeof(TResponse);
            IList<TResponse> responses = new List<TResponse>();
            if(resultType.FullName.StartsWith("System."))
                responses = (IList<TResponse>)await ExtractNativeTypesAsync(new List<TResponse>());
            else
                responses = (IList<TResponse>)await ExtractCustomTypesAsync(new List<TResponse>());
            return responses;
        }


        private void ConfigureCommand(string sqlStatement)
        {
            ClearParameters();
            _command.CommandType = System.Data.CommandType.StoredProcedure;
            _command.CommandText = sqlStatement;
        }


        private async Task<IEnumerable<TResponse>> ExtractNativeTypesAsync<TResponse>
            (IList<TResponse> responses)
            where TResponse : IQueryResponseBase
        {
            var dataReader = await _command.ExecuteReaderAsync();
            while(await dataReader.ReadAsync()) {
                object objectValue = dataReader.GetValue(0);
                responses.Add((TResponse)(objectValue != System.DBNull.Value ? objectValue : null));
            }
            return responses;
        }


        private async Task<IEnumerable<TResponse>> ExtractCustomTypesAsync<TResponse>
            (IList<TResponse> responses)
            where TResponse : IQueryResponseBase
        {
            System.Reflection.PropertyInfo[] properties = typeof(TResponse).GetProperties();
            var dataReader = await _command.ExecuteReaderAsync();
            IList<string> columns = Enumerable
                .Range(0, dataReader.FieldCount)
                .Select(dataReader.GetName)
                .ToList();
            while(await dataReader.ReadAsync()) {
                TResponse response = System.Activator.CreateInstance<TResponse>();
                foreach(System.Reflection.PropertyInfo property in properties) {
                    if(columns.Contains(property.Name.ToUpper())) {
                        object propertyName = dataReader[property.Name];
                        property.SetValue(response, propertyName != System.DBNull.Value ? System.Convert.ChangeType(propertyName, property.PropertyType) : null, null);
                    }
                }
                responses.Add(response);
            }
            return responses;
        }


    }
}
