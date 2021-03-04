using FeriaVirtual.Application.Users.Dto;

namespace FeriaVirtual.Application.Users.Interfaces
{
    public interface IUpdateUserService
    {
        void Update(UpdateUserDto userDto);
    }
}