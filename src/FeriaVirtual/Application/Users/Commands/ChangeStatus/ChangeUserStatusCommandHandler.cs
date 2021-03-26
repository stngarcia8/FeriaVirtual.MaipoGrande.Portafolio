using FeriaVirtual.Application.Users.Exceptions;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Users.Commands.ChangeStatus
{
    public class ChangeUserStatusCommandHandler
        :ICommandHandler<ChangeUserStatusCommand>
    {
        private readonly IUserRepository _repository;


        public ChangeUserStatusCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }


        public void Handle(ChangeUserStatusCommand command)
        {
            if (command is null) {
                throw new InvalidUserServiceException("Datos de usuario inválidos.");
            }
            if (command.IsActive<0 || command.IsActive > 1) {
                throw new InvalidUserServiceException("Estado de usuario inválido.");
            }
            if(command.IsActive.Equals(1))
                _repository.EnableUser(command.UserId);
            else
                _repository.DisableUser(command.UserId);
        }



    }
}
