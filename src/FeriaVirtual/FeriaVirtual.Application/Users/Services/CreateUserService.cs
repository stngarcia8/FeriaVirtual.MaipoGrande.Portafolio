using FeriaVirtual.Application.Users.Dto;
using FeriaVirtual.Application.Users.Exceptions;
using FeriaVirtual.Application.Users.Interfaces;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Events;

namespace FeriaVirtual.Application.Users.Services
{
    public class CreateUserService
        : ICreateUserService
    {
        private readonly IUserRepository _repository;
        private readonly IEventPublisher _eventPublisher;

        public CreateUserService(IUserRepository repository, IEventPublisher eventPublisher)
        {
            _repository = repository;
            _eventPublisher = eventPublisher;
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
            _eventPublisher.Publish(newUser.PullDomainEvents());
        }



    }
}
