using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Exceptions;
using Oracle.ManagedDataAccess.Client;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    class SelectionQuery
        : QueryBase, ISelectionQuery
    {

        private SelectionQuery(IDBContext dbContext)
            : base(dbContext) =>
            _command.CommandType = CommandType.Text;

        public static ISelectionQuery BuildQuery(IDBContext dbContext) =>
            new SelectionQuery(dbContext);

        public new void AddParameter(
            string parameterName, object parameterValue, DbType parameterType) =>
            base.AddParameter(parameterName, parameterValue, parameterType);

        public new void ClearParameters() =>
            base.ClearParameters();

        public TViewModel ExecuteSingleQuery<TViewModel>(string sqlStatement)
    where TViewModel : class
        {
            try {
                return string.IsNullOrWhiteSpace(sqlStatement)
                    ? throw new SelectionQueryFailedException("Consulta de selección inválida, nula o vacía.")
                    : (TViewModel)Convert.ChangeType(_command.ExecuteScalar(), typeof(TViewModel));
            } catch (Exception ex) {
                string message = $"Error en consulta de selección, comunique este problema al administrador del sistema.{Environment.NewLine}Error: {ex.Message}";
                throw new SelectionQueryFailedException(message);
            }
        }

        public IEnumerable<TViewModel> ExecuteQuery<TViewModel>(string sqlStatement)
    where TViewModel : class
        {
            if (string.IsNullOrWhiteSpace(sqlStatement)) {
                throw new SelectionQueryFailedException("Consulta de selección inválida, nula o vacía.");
            }
            _command.CommandText = sqlStatement;
            Type resultType = typeof(TViewModel);
            IList<TViewModel> results = new List<TViewModel>();
            results = resultType.FullName.StartsWith("System.")
                ? ExtractNativeTypes(results)
                : ExtractCustomTypes(results);
            return results;
        }

        private IList<TViewModel> ExtractNativeTypes<TViewModel>(IList<TViewModel> results)
            where TViewModel : class
        {
            try {
                OracleDataReader dataReader = _command.ExecuteReader();
                while (dataReader.Read()) {
                    var item = (TViewModel)(dataReader.GetValue(0) == DBNull.Value
                        ? null
                        : dataReader.GetValue(0));
                    results.Add(item);
                }
                return results;
            } catch (Exception ex) {
                string message = $"Error en consulta de selección, comunique este problema al administrador del sistema.{Environment.NewLine}Error: {ex.Message}";
                throw new SelectionQueryFailedException(message);
            }
        }

        private IList<TViewModel> ExtractCustomTypes<TViewModel>(IList<TViewModel> results)
            where TViewModel : class
        {
            try {
                PropertyInfo[] properties = typeof(TViewModel).GetProperties();
                OracleDataReader dataReader = _command.ExecuteReader();
                while (dataReader.Read()) {
                    TViewModel entity = Activator.CreateInstance<TViewModel>();
                    List<string> columns = Enumerable.Range(0, dataReader.FieldCount).Select(dataReader.GetName).ToList();
                    foreach (var (property, objectValue) in
                        from property in properties
                        where columns.Contains(property.Name.ToUpper())
                        let objectValue = dataReader[property.Name]
                        select (property, objectValue)) {
                        property.SetValue(entity, objectValue != DBNull.Value ? Convert.ChangeType(objectValue, property.PropertyType) : null, null);
                    }
                    results.Add(entity);
                }
                return results;
            } catch (Exception ex) {
                string message = $"Error en consulta de selección, comunique este problema al administrador del sistema.{Environment.NewLine}Error: {ex.Message}";
                throw new SelectionQueryFailedException(message);
            }
        }


    }
}
