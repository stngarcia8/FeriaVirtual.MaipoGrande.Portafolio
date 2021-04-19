using System.Threading.Tasks;

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
            //Context.OpenContextAsync();
        }


        public async Task  SaveChangesAsync() =>
            await Context.CommitInContextAsync();


        public async void Dispose()
        {
            await Dispose(true);
            System.GC.SuppressFinalize(this);
        }


        public async Task  Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing) await Context.CloseContextAsync();
            _disposed = true;
        }


        ~UnitOfWork() =>
            Dispose(false).GetAwaiter();


    }
}
