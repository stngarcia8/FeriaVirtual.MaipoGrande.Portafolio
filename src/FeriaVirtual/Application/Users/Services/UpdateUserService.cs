using FeriaVirtual.Application.Users.Dtos;
using FeriaVirtual.Application.Users.Exceptions;
using FeriaVirtual.Application.Users.Interfaces;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Users.Services
{
    public class UpdateUserService
        : IUpdateUserService
    {
        private readonly IUserRepository _repository;


        public UpdateUserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Update(UpdateUserDto userDto)
        {
            if (userDto is null) {
                throw new InvalidUserServiceException("Datos de usuario nulos.");
            }
            var newUser = new User(
                userDto.UserId, userDto.Firstname,
                userDto.Lastname, userDto.Dni, userDto.ProfileId);
            newUser.GenerateCredentials(userDto.CredentialId,
                userDto.Username, userDto.Password, userDto.Email, userDto.IsActive);
            _repository.Update(newUser);

            // _eventPublisher.Publish(newUser.PullDomainEvents());
        }



    }
}
