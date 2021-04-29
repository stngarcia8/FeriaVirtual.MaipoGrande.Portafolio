using FeriaVirtual.Application.Services.Employees.Queries.Counter;
using FeriaVirtual.Application.Services.Employees.Queries.SearchByCriteria;
using FeriaVirtual.Application.Services.Employees.Queries.SearchById;
using FeriaVirtual.Domain.SeedWork.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FeriaVirtual.Api.Local.Controllers.Employees.Queries
{
    [ApiController]
    public class QueryEmployeeController
        : ControllerBase
    {
        private readonly IQueryBus _queryBus;


        public QueryEmployeeController(IQueryBus queryBus) =>
            _queryBus = queryBus;


        [HttpGet]
        [Route("api/employees/{employeeid}")]
        public async Task<IActionResult> GetById(string employeeid)
        {
            try {
                var queryEmployee = new SearchEmployeeByIdQuery(employeeid);
                SearchEmployeeByIdResponse result = await _queryBus.Ask<SearchEmployeeByIdResponse>(queryEmployee);
                return StatusCode(200, result);
            } catch(Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/employees/searchbycriteria/{filterType}/{filterValue}/{limit}/{offset}")]
        public async Task<IActionResult> GetByCriteria
            (string filterType, string filterValue, int limit, int offset)
        {
            try {
                var query = new SearchEmployeeByCriteriaQuery {
                    FilterType = filterType,
                    FilterValue = filterValue,
                    Limit = limit,
                    Offset = offset
                };
                var results = await _queryBus.Ask<SearchEmployeesByCriteriaResponse>(query);
                return StatusCode(200, results.EmployeesResponse);

            } catch(Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/employees/count/{typeFilter}/{valueFilter}")]
        public async Task<IActionResult> GetCountEmployeesAsync(string typeFilter, string valueFilter)
        {
            try {
                var query = new EmployeeCounterQuery {
                    FilterType = typeFilter,
                    FilterValue = valueFilter
                };

                var result = await _queryBus.Ask<EmployeeCounterResponse>(query);
                return base.StatusCode(200,result );

            } catch(Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }



    }
}
