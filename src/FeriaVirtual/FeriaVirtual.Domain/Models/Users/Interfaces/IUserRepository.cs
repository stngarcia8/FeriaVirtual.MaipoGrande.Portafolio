using System;

namespace FeriaVirtual.Domain.Models.Users.Interfaces
{
    public interface IUserRepository
    {
        void Create(User user);
        void Update(User user);
        void EnableUser(Guid userId);
        void DisableUser(Guid userId);


    }
}