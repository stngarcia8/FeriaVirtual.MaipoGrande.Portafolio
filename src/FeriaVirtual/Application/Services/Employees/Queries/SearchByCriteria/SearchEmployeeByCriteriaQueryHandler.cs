using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.FiltersByCriteria;
using FeriaVirtual.Domain.SeedWork.Query;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Employees.Queries.SearchByCriteria
{
    public class SearchEmployeeByCriteriaQueryHandler
        : IQueryHandler<SearchEmployeeByCriteriaQuery, SearchEmployeesByCriteriaResponse>
    {
        private readonly IEmployeeRepository _repository;


        public SearchEmployeeByCriteriaQueryHandler(IEmployeeRepository repository) =>
            _repository = repository;


        public async Task<SearchEmployeesByCriteriaResponse> Handle(SearchEmployeeByCriteriaQuery query)
        {
            if(query is null)
                throw new InvalidEmployeeServiceException("Parametros de consulta inválidos.");

            Criteria criteria = new EmployeeFilter().Filters.GetFilter(query.FilterType);
            if(criteria is null)
                throw new InvalidEmployeeServiceException("Criterio de consulta inválido.");
            criteria.ChangeFieldValue(query.FilterValue);

            var response = new SearchEmployeesByCriteriaResponse(
            await _repository.SearchByCriteria<SearchEmployeeByCriteriaResponse>
                (criteria, query.Limit, query.Offset));
            return response;
        }


    }
}
