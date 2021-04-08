using System.Collections.Generic;

namespace FeriaVirtual.Application.Services.Employees.Queries.SearchByCriteria
{
    public class SearchEmployeesByCriteriaResponse
    {
        public IEnumerable<SearchEmployeeByCriteriaResponse> EmployeesResponse { get; protected set; }


        public SearchEmployeesByCriteriaResponse(IEnumerable<SearchEmployeeByCriteriaResponse> employeesResponse) =>
            EmployeesResponse = employeesResponse;


    }
}
