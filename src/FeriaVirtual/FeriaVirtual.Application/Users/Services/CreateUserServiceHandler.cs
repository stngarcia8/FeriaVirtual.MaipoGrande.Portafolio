using FeriaVirtual.Application.Users.Interfaces;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Command;

namespace FeriaVirtual.Application.Users.Services
{
    public class CreateUserServiceHandler
        : ICommandHandler, ICreateUserServiceHandler
    {
        private readonly IUserRepository _repository;
        private readonly CreateUserServiceCommand _userCommand;

        public CreateUserServiceHandler(IUserRepository repository, CreateUserServiceCommand userCommand)
        {
            _repository = repository;
            _userCommand = userCommand;
        }

        public void Handle()
        {
            var newUser = new User(
                    _userCommand.Firstname, _userCommand.Lastname,
                    _userCommand.Dni, _userCommand.ProfileId);
            newUser.CreateCredentials(_userCommand.Username,
                _userCommand.Password, _userCommand.Email);
            _repository.Create(newUser);
        }



    }
}
