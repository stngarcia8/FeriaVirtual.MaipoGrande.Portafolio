using FeriaVirtual.Domain.SeedWork.Query;
using System.Collections.Generic;

namespace FeriaVirtual.Application.Users.Queries.SearchAll
{
    public class SearchAllUsersResponse
    {
        public IEnumerable<SearchAllUserResponse> AllUsers { get; protected set; }


        public SearchAllUsersResponse(IEnumerable<SearchAllUserResponse> allUsers) =>
            AllUsers = allUsers;


    }
}
