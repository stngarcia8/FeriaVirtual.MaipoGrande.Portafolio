using FeriaVirtual.Domain.SeedWork.FiltersByCriteria;
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
            (Criteria criteria, int limit = 0, int offset = 0)
            where TResponse : IQueryResponseBase;

        Task<int> CountEmployeesAsync(Criteria criteria);


    }
}
