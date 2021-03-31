using System.Collections.Generic;

namespace FeriaVirtual.Application.Users.Queries.SearchBycriteria
{
    public class SearchUsersByCriteriaResponse

    {
        public IEnumerable<SearchUserByCriteriaResponse> UsersResponse { get; protected set; }


        public SearchUsersByCriteriaResponse(IEnumerable<SearchUserByCriteriaResponse> usersResponse) =>
            UsersResponse = usersResponse;


    }
}
