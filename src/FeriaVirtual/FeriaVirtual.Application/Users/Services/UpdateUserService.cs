using FeriaVirtual.Application.Users.Dto;
using FeriaVirtual.Application.Users.Interfaces;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Events;

namespace FeriaVirtual.Application.Users.Services
{
    public class UpdateUserService
        : IUpdateUserService
    {
        private readonly IUserRepository _repository;
        private readonly IEventPublisher _eventPublisher;


        public UpdateUserService(IUserRepository repository, IEventPublisher eventPublisher)
        {
            _repository = repository;
            _eventPublisher = eventPublisher;
        }


        public void Update(UpdateUserDto userDto)
        {
            if (userDto is null) {
                throw new InvalidUserServiceException("Datos de usuario nulos.");
            }
            var newUser = new User(
                userDto.UserId, userDto.Firstname,
                userDto.Lastname, userDto.Dni, userDto.ProfileId);
            newUser.GenerateCredentials(userDto.CredentialId,
                userDto.Username, userDto.Password, userDto.Email, userDto.IsActive);
            _repository.Update(newUser);
            _eventPublisher.Publish(newUser.PullDomainEvents());
        }


    }
}
