using System;
using System.Threading.Tasks;

namespace FeriaVirtual.Infrastructure.SeedWork
{
    public interface IUnitOfWork
        : IDisposable
    {
        IContextManager Context { get; }

        Task SaveChangesAsync();


    }
}
