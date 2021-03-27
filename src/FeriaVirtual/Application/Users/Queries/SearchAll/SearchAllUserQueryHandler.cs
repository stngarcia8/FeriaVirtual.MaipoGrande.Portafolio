using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;
using System.Collections.Generic;

namespace FeriaVirtual.Application.Users.Queries.SearchAll
{
    public class SearchAllUserQueryHandler
        : IQueryHandler<SearchAllUserQuery, SearchAllUsersResponse>
    {
        private readonly IUserRepository _repository;


        public SearchAllUserQueryHandler(IUserRepository repository) =>
            _repository = repository;


        public SearchAllUsersResponse Handle(SearchAllUserQuery query)
        {
            return  (SearchAllUsersResponse)new SearchAllUsersResponse(_repository.SearchAll<SearchAllUserResponse>(query.PageNumber));
            
        }

            


    }
}
