using FeriaVirtual.Domain.SeedWork;
using FeriaVirtual.Infrastructure.Persistence.OracleContext;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Queries;

namespace FeriaVirtual.Infrastructure.Persistence
{
    public abstract class RepositoryBase
    {
        protected IDBConfig _dbConfig;
        protected string _sqlStatement;

        public void Execute<TEntity>(TEntity entity)
            where TEntity:EntityBase
        {
            using (var context = DBContext.BuildContext(_dbConfig)) {
                var qm = QueryManager.BuildManager(context);
                qm.ExecuteStoredProcedure<TEntity>(_sqlStatement, entity);
            }
        }

    }
}
