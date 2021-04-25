using FeriaVirtual.Application.Services.Users.DomainServices;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Commands;
using FeriaVirtual.Domain.SeedWork.Events;
using FeriaVirtual.Domain.SeedWork.Query;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Users.Commands.Update
{
    public class UpdateUserCommandHandler
        : ICommandHandler<UpdateUserCommand>
    {
        private readonly IUserRepository _repository;
        private readonly IEventBus _eventBus;
        private readonly IUserUniquenessChecker _uniquenessChecker;



        public UpdateUserCommandHandler
            (IUserRepository repository,
            IQueryBus queryBus,
            IEventBus eventBus)
        {
            _repository = repository;
            _uniquenessChecker = new UserUniquenessChecker(queryBus);
            _eventBus = eventBus;
        }

        public async Task Handle(UpdateUserCommand command)
        {
            if(command is null)
                throw new InvalidUserServiceException("Datos de usuario nulos.");

            await _uniquenessChecker.Check(
                command.UserId.ToString(), command.Username,
                command.Dni, command.Email
                );

            User newUser = new(command.UserId, command.Firstname,
                command.Lastname, command.Dni, command.ProfileId,
                command.CredentialId, command.Username,
                command.Email, command.IsActive, _uniquenessChecker);

            var tasks = Task.WhenAll(
                _repository.Update(newUser),
                _eventBus.PublishAsync(newUser.PullDomainEvents())
                );
            await tasks;
        }


    }
}
