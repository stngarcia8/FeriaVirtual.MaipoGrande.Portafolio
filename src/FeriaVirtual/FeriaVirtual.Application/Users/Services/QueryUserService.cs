﻿using System;
using System.Collections.Generic;
using FeriaVirtual.Application.Users.Interfaces;
using FeriaVirtual.Application.Users.ViewModels;
using FeriaVirtual.Domain.Models.Users.Interfaces;

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
            var userGuid = new Guid(userId);
            return _repository.SearchById<UserViewModel>(userGuid);
        }

        public IList<UserViewModel> SearchAll(int pageNumber=0) =>
            _repository.SearchAll<UserViewModel>(pageNumber);


        public IList<UserViewModel> SearchByCriteria(string filter)
        {
            Func<UserViewModel, bool> criteria = (UserViewModel x) => x.LastName.ToLower().Contains(filter.ToLower());
            return _repository.SearchByCriteria <UserViewModel>(criteria);
        }

        public int CountAllUsers() =>
            _repository.CountAllUsers();

        public int CountEnabledUser() =>
            _repository.CountEnabledUsers();

        public int CountDisabledUser() =>
            _repository.CountDisabledUsers();


    }
}
