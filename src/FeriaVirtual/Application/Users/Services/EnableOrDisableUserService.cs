using FeriaVirtual.Application.Users.Dtos;
using FeriaVirtual.Application.Users.Exceptions;
using FeriaVirtual.Application.Users.Interfaces;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Users.Services
{
    public class EnableOrDisableUserService
        : IEnableOrDisableUserService
    {
        private readonly IUserRepository _repository;


        public EnableOrDisableUserService(IUserRepository repository)
        {
            _repository = repository;
        }


        public void EnableUser(EnableOrDisableUserDto userDto)
        {
            if (userDto is null) {
                throw new InvalidUserServiceException("Datos de usuario nulos.");
            }
            _repository.EnableUser(userDto.UserId);
        }


        public void DisableUser(EnableOrDisableUserDto userDto)
        {
            if (userDto is null) {
                throw new InvalidUserServiceException("Datos de usuario nulos.");
            }
            _repository.DisableUser(userDto.UserId);
        }


    }
}
