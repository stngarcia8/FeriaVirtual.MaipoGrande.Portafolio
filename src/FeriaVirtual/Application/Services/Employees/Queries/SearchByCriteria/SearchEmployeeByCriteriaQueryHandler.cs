using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;
using System;

namespace FeriaVirtual.Application.Services.Employees.Queries.SearchByCriteria
{
    public class SearchEmployeeByCriteriaQueryHandler
        : IQueryHandler<SearchEmployeeByCriteriaQuery, SearchEmployeesByCriteriaResponse>
    {
        private readonly IEmployeeRepository _repository;


        public SearchEmployeeByCriteriaQueryHandler(IEmployeeRepository repository) =>
            _repository = repository;


        public SearchEmployeesByCriteriaResponse Handle(SearchEmployeeByCriteriaQuery query) =>
            query is null
                ? throw new InvalidEmployeeServiceException("Parametros de consulta inválidos.")
                : new SearchEmployeesByCriteriaResponse(_repository.SearchByCriteria(GetCriteria(query.SearchType, query.SearchValue), query.PageNumber));


        private Func<SearchEmployeeByCriteriaResponse, bool> GetCriteria
            (string searchType, object searchValue = null) =>
            searchType.Trim().ToLower() switch {
                "search_by_name" => (SearchEmployeeByCriteriaResponse x) => x.FullName.ToLower().Contains(searchValue.ToString().ToLower()),
                "search_by_dni" => (SearchEmployeeByCriteriaResponse x) => x.Dni.ToLower().Equals(searchValue.ToString().ToLower()),
                "search_by_profile" => (SearchEmployeeByCriteriaResponse x) => x.ProfileName.ToLower().Contains(searchValue.ToString().ToLower()),
                "search_by_status" => (SearchEmployeeByCriteriaResponse x) => x.UserStatus.ToLower().Contains(searchValue.ToString().ToLower()),
                _ => null,
            };



    }
}
