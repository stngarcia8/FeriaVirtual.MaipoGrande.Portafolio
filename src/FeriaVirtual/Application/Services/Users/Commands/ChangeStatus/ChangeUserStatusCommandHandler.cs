using FeriaVirtual.Application.Users.Commands.ChangeStatus;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Commands;
using FeriaVirtual.Domain.SeedWork.Events;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Users.Commands.ChangeStatus
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


        public async Task Handle(ChangeUserStatusCommand command)
        {
            if(command is null) {
                throw new InvalidUserServiceException("Datos de usuario inválidos.");
            }
            if(command.IsActive < 0 || command.IsActive > 1) {
                throw new InvalidUserServiceException("Estado de usuario inválido.");
            }
            var user = new User(command.UserId);
            Task tasks;

            if(command.IsActive.Equals(1)) {
                user.EnableUser();
                tasks = Task.WhenAll(
                    _repository.EnableUser(user.UserId),
                    _eventBus.PublishAsync(user.PullDomainEvents())
                    );
            } else {
                user.DisableUser();
                tasks = Task.WhenAll(
                    _repository.DisableUser(user.UserId),
                    _eventBus.PublishAsync(user.PullDomainEvents())
                    );
            }
            await tasks;
        }



    }
}
