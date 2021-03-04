using FeriaVirtual.Application.Users.Dto;

namespace FeriaVirtual.Application.Users.Interfaces
{
    public interface ICreateUserService
    {
        void Create(CreateUserDto userDto);
    }
}