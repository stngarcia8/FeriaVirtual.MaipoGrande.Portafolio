using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Commands;
using FeriaVirtual.Domain.SeedWork.Events;

namespace FeriaVirtual.Application.Services.Users.Create
{
    public class CreateUserCommandHandler
        : ICommandHandler<CreateUserCommand>
    {
        private readonly IUserRepository _repository;
        private readonly IEventBus _eventBus;


        public CreateUserCommandHandler
            (IUserRepository repository, IEventBus eventBus)
        {
            _repository = repository;
            _eventBus = eventBus;
        }


        public void Handle(CreateUserCommand command)
        {
            if (command is null) {
                throw new InvalidUserServiceException("Datos de usuario nulos.");
            }
            var newUser = new User(
                command.Firstname, command.Lastname,
                command.Dni, command.ProfileId, command.Username, command.Password, command.Email);
            _repository.Create(newUser);
            _eventBus.Publish(newUser.PullDomainEvents());
        }


    }
}
