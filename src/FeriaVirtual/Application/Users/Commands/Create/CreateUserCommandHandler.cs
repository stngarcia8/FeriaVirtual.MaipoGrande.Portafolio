using FeriaVirtual.Application.Users.Exceptions;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Commands;

namespace FeriaVirtual.Application.Users.Services.Create
{
    public class CreateUserCommandHandler
        : ICommandHandler<CreateUserCommand>
    {
        private readonly IUserRepository _repository;


        public CreateUserCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }


        public void Handle(CreateUserCommand command)
        {
            if (command is null) {
                throw new InvalidUserServiceException("Datos de usuario nulos.");
            }
            var newUser = new User(
                command.Firstname, command.Lastname,
                command.Dni, command.ProfileId);
            newUser.CreateCredentials(command.Username,
                command.Password, command.Email);
            _repository.Create(newUser);
        }


    }
}
