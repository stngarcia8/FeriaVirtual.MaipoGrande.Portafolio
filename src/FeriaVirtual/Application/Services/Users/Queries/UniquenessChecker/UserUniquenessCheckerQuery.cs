﻿using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Services.Users.Queries.UniquenessChecker
{
    public class UserUniquenessCheckerQuery
        : Query
    {
        public string Username { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }


        public UserUniquenessCheckerQuery() { }


    }
}
