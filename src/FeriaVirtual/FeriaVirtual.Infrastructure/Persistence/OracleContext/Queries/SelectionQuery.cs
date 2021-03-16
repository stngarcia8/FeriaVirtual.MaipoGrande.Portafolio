using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using FeriaVirtual.Domain.SeedWork;
using Oracle.ManagedDataAccess.Client;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    class SelectionQuery
        : QueryParameter
    {
        private SelectionQuery(OracleCommand command)
            : base(command) { }

        public static SelectionQuery BuildQuery(OracleCommand command) =>
            new SelectionQuery(command);

        public TResult ExecuteQuery<TResult>(string spName)
        {
            try {
                if (string.IsNullOrWhiteSpace(spName)) {
                    throw new QueryExecutorFailedException("No ha especificado una consulta de selección para ejecutar.");
                }
                ConfigureCommand(spName);
                AddResultsParameter();
                return (TResult)Convert.ChangeType(_command.ExecuteScalar(), typeof(TResult));

            } catch (Exception ex) {
                string message = $"Error en consulta de selección, comunique este problema al administrador del sistema.{Environment.NewLine}Error: {ex.Message}";
                throw new QueryExecutorFailedException(message);
            }
        }


        public IEnumerable<TViewModel> ExecuteQuery<TViewModel>
            (string sqlStatement, Dictionary<string, object> parameters = null)
            where TViewModel : IViewModelBase
        {
            if (string.IsNullOrWhiteSpace(sqlStatement)) {
                throw new QueryExecutorFailedException("No ha especificado una consulta de selección para ejecutar.");
            }
            ConfigureCommand(sqlStatement);
            if (parameters != null) CreateQueryParameters(parameters);
            AddResultsParameter();

            var resultType = typeof(TViewModel);
            IList<TViewModel> results = new List<TViewModel>();
            if (resultType.FullName.StartsWith("System."))
                results = ExtractNativeTypes(results);
            else
                results = ExtractCustomTypes(results);
            return results;
        }

        private void ConfigureCommand(string sqlStatement)
        {
            ClearParameters();
            _command.CommandType = CommandType.StoredProcedure;
            _command.CommandText = sqlStatement;
        }

        private IList<TViewModel> ExtractNativeTypes<TViewModel>
            (IList<TViewModel> results)
            where TViewModel : IViewModelBase
        {
            try {
                var dataReader = _command.ExecuteReader();
                while (dataReader.Read()) {
                    object objectValue = dataReader.GetValue(0);
                    results.Add((TViewModel)(objectValue != DBNull.Value ? objectValue : null));
                }
                return results;
            } catch (Exception ex) {
                string message = $"Error en consulta de selección, comunique este problema al administrador del sistema.{Environment.NewLine}Error: {ex.Message}";
                throw new QueryExecutorFailedException(message);
            }
        }

        private IList<TViewModel> ExtractCustomTypes<TViewModel>
            (IList<TViewModel> results)
            where TViewModel : IViewModelBase
        {
            try {
                PropertyInfo[] properties = typeof(TViewModel).GetProperties();
                var dataReader = _command.ExecuteReader();
                IList<string> columns = Enumerable
                    .Range(0, dataReader.FieldCount)
                    .Select(dataReader.GetName)
                    .ToList();
                while (dataReader.Read()) {
                    TViewModel viewModel = Activator.CreateInstance<TViewModel>();
                    foreach (var property in properties) {
                        if (columns.Contains(property.Name.ToUpper())) {
                            object propertyName = dataReader[property.Name];
                            property.SetValue(viewModel, propertyName != DBNull.Value ? Convert.ChangeType(propertyName, property.PropertyType) : null, null);
                        }
                    }
                    results.Add(viewModel);
                }
                return results;
            } catch (Exception ex) {
                string message = $"Error en consulta de selección, comunique este problema al administrador del sistema.{Environment.NewLine}Error: {ex.Message}";
                throw new QueryExecutorFailedException(message);
            }
        }


   }
}
