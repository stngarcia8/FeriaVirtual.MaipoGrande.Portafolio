using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Commands;
using FeriaVirtual.Domain.SeedWork.Events;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Users.Commands.Update
{
    public class UpdateUserCommandHandler
        : ICommandHandler<UpdateUserCommand>
    {
        private readonly IUserRepository _repository;
        private readonly IEventBus _eventBus;


        public UpdateUserCommandHandler
            (IUserRepository repository, IEventBus eventBus)
        {
            _repository = repository;
            _eventBus = eventBus;
        }

        public async Task Handle(UpdateUserCommand command)
        {
            if(command is null) {
                throw new InvalidUserServiceException("Datos de usuario nulos.");
            }
            User newUser = new(command.UserId, command.Firstname,
                command.Lastname, command.Dni, command.ProfileId,
                command.CredentialId, command.Username,
                command.Password, command.Email, command.IsActive);

            var tasks = Task.WhenAll(
                _repository.Update(newUser),
                _eventBus.PublishAsync(newUser.PullDomainEvents())
                );
            await tasks;
        }


    }
}
