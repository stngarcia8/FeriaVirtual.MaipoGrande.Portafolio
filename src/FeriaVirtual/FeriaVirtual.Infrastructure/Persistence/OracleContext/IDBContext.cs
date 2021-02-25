using System;
using Oracle.ManagedDataAccess.Client;

namespace FeriaVirtual.Infrastructure.Persistence.OracleContext
{
    public interface IDBContext
        :IDisposable
    {
        OracleConnection GetDBContext { get; }
        OracleTransaction GetDBContextTransaction { get; }

        void CommitContext();
        new void Dispose();
        void RollbackContext();


    }
}