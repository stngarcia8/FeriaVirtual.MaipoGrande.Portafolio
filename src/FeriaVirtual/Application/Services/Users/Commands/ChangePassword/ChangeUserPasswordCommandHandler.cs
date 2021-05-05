using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Commands;
using FeriaVirtual.Domain.SeedWork.Events;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Users.Commands.ChangePassword
{
    public class ChangeUserPasswordCommandHandler
        : ICommandHandler<ChangeUserPasswordCommand>
    {
        private readonly IUserRepository _repository;
        private readonly IEventBus _eventBus;


        public ChangeUserPasswordCommandHandler
            (IUserRepository repository, IEventBus eventBus)
        {
            _repository = repository;
            _eventBus = eventBus;
        }


        public async Task Handle(ChangeUserPasswordCommand command)
        {
            if(command is null)
                throw new InvalidUserServiceException("Datos de cambio de contraseña inválida.");

            var user = new User(command.UserId);
            user.ChangePassword(command.Password);
            Task tasks= Task.WhenAll(
                    _repository.ChangePasswordAsync(user.UserId.ToString(), user.GetCredential.EncryptedPassword),
                    _eventBus.PublishAsync(user.PullDomainEvents())
                    );
            await tasks;
        }


    }
}
