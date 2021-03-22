using System;

namespace FeriaVirtual.Infrastructure.SeedWork
{
    public class UnitOfWork 
        : IUnitOfWork
    {
        private bool _disposed;
        public IContextManager Context { get; }

        public UnitOfWork(IContextManager context)
        {
            Context = context;
            Context.OpenContext();
        }


        public void SaveChanges() =>
            Context.CommitInContext();


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing) Context.CloseContext();
            _disposed = true;
        }


        ~UnitOfWork()
        {
            Dispose(false);
        }


    }
}
