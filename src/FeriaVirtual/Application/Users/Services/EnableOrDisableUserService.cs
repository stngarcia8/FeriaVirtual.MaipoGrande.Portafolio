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


        public void EnableUser(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId)) {
                throw new InvalidUserServiceException("Identificador de usuario inválido.");
            }
            var newUserId = new Guid(userId);
            _repository.EnableUser(newUserId);
        }


        public void DisableUser(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId)) {
                throw new InvalidUserServiceException("Identificador de usuario inválido.");
            }
            var newUserId = new Guid(userId);
            _repository.DisableUser(newUserId);
        }


    }
}
