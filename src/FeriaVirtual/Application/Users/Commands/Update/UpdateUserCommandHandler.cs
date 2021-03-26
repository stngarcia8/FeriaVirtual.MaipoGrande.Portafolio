using FeriaVirtual.Application.Users.Exceptions;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Users.Commands.Update
{
    public class UpdateUserCommandHandler
        :ICommandHandler<UpdateUserCommand>
    {
        private readonly IUserRepository _repository;


        public UpdateUserCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Handle(UpdateUserCommand command)
        {
            if (command is null) {
                throw new InvalidUserServiceException("Datos de usuario nulos.");
            }
            var newUser = new User(
                command.UserId, command.Firstname,
                command.Lastname, command.Dni, command.ProfileId);
            newUser.GenerateCredentials(command.CredentialId,
                command.Username, command.Password, command.Email, command.IsActive);
            _repository.Update(newUser);
        }


    }
}
