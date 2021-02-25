using System.Data;
using FeriaVirtual.Domain.SeedWork;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries
{
    public class QueryManager
    {
        private readonly IDBContext _dbContext;

        private QueryManager(IDBContext dbContext) =>
            _dbContext = dbContext;

        public static QueryManager BuildManager(IDBContext dbContext) =>
            new QueryManager(dbContext);

        public void ExecuteStoredProcedure<TEntity>(string storedProcedureName, TEntity entity)
            where TEntity : EntityBase
        {
            var query = StoredProcedureQuery.BuildQuery(_dbContext);
            if (entity.GetPrimitives() != null) {
                foreach (var primitive in entity.GetPrimitives())
                    query.AddParameter($"p{primitive.Key}", primitive.Value, GetFieldDbType(primitive.Value));
            }
            query.Execute(storedProcedureName);
        }

        private DbType GetFieldDbType(object value)
        {
            Type obj = value.GetType();
            return obj.Name switch {
                "Datetime" => DbType.Date,
                "float" => DbType.Double,
                "Int32" => DbType.Int32,
                _ => DbType.String,
            };
        }





    }
}
