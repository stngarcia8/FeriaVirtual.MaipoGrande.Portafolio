using FeriaVirtual.Application.Users.Dtos;

namespace FeriaVirtual.Application.Users.Interfaces
{
    public interface ICreateUserService
    {
        void Create(CreateUserDto userDto);


    }
}
