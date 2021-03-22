using System;

namespace FeriaVirtual.Infrastructure.SeedWork
{
    public interface IUnitOfWork
        : IDisposable
    {
        IContextManager Context { get; }

        void SaveChanges();


    }
}
