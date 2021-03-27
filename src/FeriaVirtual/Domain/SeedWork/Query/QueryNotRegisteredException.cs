using System;

namespace FeriaVirtual.Domain.SeedWork.Query
{
    public class QueryNotRegisteredException
        : Exception
    {
        public QueryNotRegisteredException(Query query)
            : base($"Consulta {query} no registrada.") { }


    }
}
