using System.Threading.Tasks;
using FeriaVirtual.Domain.SeedWork;

namespace FeriaVirtual.Infrastructure.Persistence 
    {
    public interface IRepositoryBase<TEntity>
        where TEntity : EntityBase
    {
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);


    }
}