using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;
using System;

namespace FeriaVirtual.Application.Services.Users.Queries.SearchBycriteria
{
    public class SearchUserByCriteriaQueryHandler
        : IQueryHandler<SearchUserByCriteriaQuery, SearchUsersByCriteriaResponse>
    {
        private readonly IUserRepository _repository;


        public SearchUserByCriteriaQueryHandler(IUserRepository repository) =>
            _repository = repository;


        public SearchUsersByCriteriaResponse Handle(SearchUserByCriteriaQuery query) =>
            query is null
                ? throw new InvalidUserServiceException("Parametros de consulta inválidos.")
                : new SearchUsersByCriteriaResponse(_repository.SearchByCriteria(GetCriteria(query.SearchType, query.SearchValue), query.PageNumber));


        private Func<SearchUserByCriteriaResponse, bool> GetCriteria
            (string field, object filter = null) =>
            field.Trim().ToLower() switch {
                "search_by_name" => (SearchUserByCriteriaResponse x) => x.FullName.ToLower().Contains(filter.ToString().ToLower()),
                "search_by_dni" => (SearchUserByCriteriaResponse x) => x.Dni.ToLower().Equals(filter.ToString().ToLower()),
                "search_by_profile" => (SearchUserByCriteriaResponse x) => x.ProfileName.ToLower().Contains(filter.ToString().ToLower()),
                "search_by_status" => (SearchUserByCriteriaResponse x) => x.UserStatus.ToLower().Contains(filter.ToString().ToLower()),
                _ => null,
            };



    }
}
