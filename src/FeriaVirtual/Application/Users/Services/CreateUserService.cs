using FeriaVirtual.Application.Users.Dtos;
using FeriaVirtual.Application.Users.Exceptions;
using FeriaVirtual.Application.Users.Interfaces;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;

namespace FeriaVirtual.Application.Users.Services
{
    public class CreateUserService
        : ICreateUserService
    {
        private readonly IUserRepository _repository;


        public CreateUserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Create(CreateUserDto userDto)
        {
            if (userDto is null) {
                throw new InvalidUserServiceException("Datos de usuario nulos.");
            }
            var newUser = new User(
                    userDto.Firstname, userDto.Lastname,
                    userDto.Dni, userDto.ProfileId);
            newUser.CreateCredentials(userDto.Username,
                userDto.Password, userDto.Email);
            _repository.Create(newUser);

            //_eventPublisher.Publish(newUser.PullDomainEvents());
        }



    }
}
