using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Employees.Queries.Counter
{
    public class EmployeeCounterQueryHandler
        : IQueryHandler<EmployeeCounterQuery, EmployeeCounterResponse>
    {
        private readonly IEmployeeRepository _repository;


        public EmployeeCounterQueryHandler(IEmployeeRepository repository) =>
            _repository = repository;


        public async Task<EmployeeCounterResponse> Handle(EmployeeCounterQuery query)
        {
            if(query is null)
                throw new InvalidEmployeeServiceException("Parametros de consulta inválidos.");

            var employeeFilters = new EmployeeFilter();
            var filter = employeeFilters.Filters.GetFilter(query.FilterType);
            if(filter is null)
                throw new InvalidEmployeeServiceException("Criterio de consulta inválido.");
            filter.ChangeFieldValue(query.FilterValue);

            return new EmployeeCounterResponse {
                Total = await _repository.CountEmployeesAsync(filter)
            };
        }



    }
}



