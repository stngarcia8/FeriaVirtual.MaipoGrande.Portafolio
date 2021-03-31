using FeriaVirtual.Domain.SeedWork.Query;
using System;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.Models.Users.Interfaces
{
    public interface IEmployeeRepository
    {
        TResponse SearchById<TResponse>(Guid userId)
            where TResponse : IQueryResponseBase;

        IEnumerable<TResponse> SearchByCriteria<TResponse>
            (Func<TResponse, bool> filters = null, int pageNumber = 0)
            where TResponse : IQueryResponseBase;

        int CountAllEmployees();



    }
}
