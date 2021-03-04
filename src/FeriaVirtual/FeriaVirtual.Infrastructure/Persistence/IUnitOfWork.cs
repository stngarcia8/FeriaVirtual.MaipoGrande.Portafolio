using System;
using FeriaVirtual.Infrastructure.Persistence.OracleContext;

namespace FeriaVirtual.Infrastructure.Persistence
{
    public interface IUnitOfWork
        :IDisposable
    {
        IContextManager Context { get; }

        void SaveChanges();


    }
}