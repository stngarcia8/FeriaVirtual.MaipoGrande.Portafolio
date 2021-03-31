using FeriaVirtual.Domain.SeedWork.Query;
using System;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.Models.Users.Interfaces
{
    public interface IUserRepository
    {
        void Create(User user);
        void Update(User user);
        void EnableUser(Guid userId);
        void DisableUser(Guid userId);

        TResponse SearchById<TResponse>(Guid userId)
            where TResponse : IQueryResponseBase;

        IEnumerable<TResponse> SearchByCriteria<TResponse>
            (Func<TResponse, bool> filters = null, int pageNumber = 0)
            where TResponse : IQueryResponseBase;

        int CountAllUsers();



    }
}
