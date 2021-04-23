using FeriaVirtual.Domain.SeedWork.Query;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeriaVirtual.Domain.Models.Users.Interfaces
{
    public interface IUserRepository
    {
        Task CreateAsync(User user);
        Task Update(User user);
        Task EnableUser(Guid userId);
        Task DisableUser(Guid userId);

        Task<TResponse> SearchById<TResponse>(Guid userId)
            where TResponse : IQueryResponseBase;

        Task<IEnumerable<TResponse>> SearchByCriteria<TResponse>
            (Func<TResponse, bool> filters = null, int pageNumber = 0)
            where TResponse : IQueryResponseBase;

        Task<int> CountAllUsers();

        Task<TResponse> UserUniquenessChecker<TResponse>
            (string username, string dni, string email)
            where TResponse : IQueryResponseBase;



    }
}
