using FeriaVirtual.Application.Users.Dto;

namespace FeriaVirtual.Application.Users.Interfaces
{
    public interface IEnableOrDisableUserService
    {
        void EnableUser(EnableOrDisableUserDto userDto);
        void DisableUser(EnableOrDisableUserDto userDto);


    }
}