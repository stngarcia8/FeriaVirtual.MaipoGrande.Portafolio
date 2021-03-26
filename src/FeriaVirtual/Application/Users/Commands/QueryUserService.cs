using FeriaVirtual.Application.Users.Exceptions;
using FeriaVirtual.Application.Users.Interfaces;
using FeriaVirtual.Application.Users.ViewModels;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using System;
using System.Collections.Generic;

namespace FeriaVirtual.Application.Users.Services
{
    public class QueryUserService
        : IQueryUserService
    {
        private readonly IUserRepository _repository;


        public QueryUserService(IUserRepository repository) =>
            _repository = repository;


        public UserViewModel SearchById(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId)) {
                throw new InvalidUserServiceException("Identificador de usuario inválido.");
            }
            var userGuid = new Guid(userId);
            return _repository.SearchById<UserViewModel>(userGuid);
        }


        public IEnumerable<UserListViewModel> SearchAll(int pageNumber = 0)
        {
            return _repository.SearchAll<UserListViewModel>(pageNumber);
        }


        public int Count()
        {
            return _repository.CountAllUsers();
        }


    }
}
