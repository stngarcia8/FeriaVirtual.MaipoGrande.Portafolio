using FeriaVirtual.Application.Users.Dtos;

namespace FeriaVirtual.Application.Users.Interfaces
{
    public interface IEnableOrDisableUserService
    {
        void EnableUser(string userId);
        void DisableUser(string userId);


    }
}
