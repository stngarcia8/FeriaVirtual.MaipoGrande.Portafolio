using FeriaVirtual.Application.Users.Exceptions;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Commands;
using FeriaVirtual.Domain.SeedWork.Events;

namespace FeriaVirtual.Application.Users.Commands.ChangeStatus
{
    public class ChangeUserStatusCommandHandler
        : ICommandHandler<ChangeUserStatusCommand>
    {
        private readonly IUserRepository _repository;
        private readonly IEventBus _eventBus;


        public ChangeUserStatusCommandHandler
            (IUserRepository repository, IEventBus eventBus)
        {
            _repository = repository;
            _eventBus = eventBus;
        }


        public void Handle(ChangeUserStatusCommand command)
        {
            if (command is null) {
                throw new InvalidUserServiceException("Datos de usuario inválidos.");
            }
            if (command.IsActive < 0 || command.IsActive > 1) {
                throw new InvalidUserServiceException("Estado de usuario inválido.");
            }
            var user = new User(command.UserId);
            if (command.IsActive.Equals(1)) {
                user.EnableUser();
                _repository.EnableUser(user.UserId);
            } else {
                user.DisableUser();
                _repository.DisableUser(user.UserId);
            }
            _eventBus.Publish(user.PullDomainEvents());
        }



    }
}
