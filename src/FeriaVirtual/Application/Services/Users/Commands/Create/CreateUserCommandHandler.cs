using FeriaVirtual.Application.Services.Users.DomainServices;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Commands;
using FeriaVirtual.Domain.SeedWork.Events;
using FeriaVirtual.Domain.SeedWork.Query;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Users.Create
{
    public class CreateUserCommandHandler
        : ICommandHandler<CreateUserCommand>
    {
        private readonly IUserRepository _repository;
        private readonly IUserUniquenessChecker _uniquenessChecker;
        private readonly IEventBus _eventBus;


        public CreateUserCommandHandler
            (IUserRepository repository,
            IQueryBus queryBus,
            IEventBus eventBus)
        {
            _repository = repository;
            _uniquenessChecker = new UserUniquenessChecker(queryBus);
            _eventBus = eventBus;
        }


        public async Task Handle(CreateUserCommand command)
        {
            if(command is null)
                throw new InvalidUserServiceException("Datos de usuario nulos.");

            await _uniquenessChecker.Check(
                command.Username, command.Dni, command.Email
                );

            var newUser = new User(
                    command.Firstname, command.Lastname,
                    command.Dni, command.ProfileId,
                    command.Username, command.Password,
                    command.Email, _uniquenessChecker
                    );

            Task tasks = Task.WhenAll(
                _repository.CreateAsync(newUser),
                _eventBus.PublishAsync(newUser.PullDomainEvents())
                );
            await tasks;
        }


    }
}
