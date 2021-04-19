using FeriaVirtual.Domain.SeedWork.Query;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeriaVirtual.Domain.Models.Users.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<TResponse> SearchById<TResponse>(Guid userId)
            where TResponse : IQueryResponseBase;

        Task<IEnumerable<TResponse>> SearchByCriteria<TResponse>
            (Func<TResponse, bool> filters = null, int pageNumber = 0)
            where TResponse : IQueryResponseBase;

        Task<int> CountAllEmployees();



    }
}
