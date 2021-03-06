using FeriaVirtual.Application.Services.Employees.Queries.Counter;
using FeriaVirtual.Application.Services.Employees.Queries.SearchByCriteria;
using FeriaVirtual.Application.Services.Employees.Queries.SearchById;
using FeriaVirtual.Domain.SeedWork.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FeriaVirtual.Api.Local.Controllers.Employees
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
        [Route("api/employees/all/{pageNumber}")]
        public async Task<IActionResult> GetAll(int pageNumber = 0)
        {
            try {
                SearchEmployeeByCriteriaQuery query = new("search_all", "", pageNumber);
                SearchEmployeesByCriteriaResponse results = await _queryBus.Ask<SearchEmployeesByCriteriaResponse>(query);
                return StatusCode(200, results.EmployeesResponse);
            } catch(Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/employees/searchbycriteria/{searchtype}/{searchvalue}/{pagenumber}")]
        public async Task<IActionResult>
            GetByCriteria(string searchtype, string searchvalue, int pagenumber)
        {
            try {
                SearchEmployeeByCriteriaQuery query = new(searchtype, searchvalue, pagenumber);
                var results = await _queryBus.Ask<SearchEmployeesByCriteriaResponse>(query);
                return StatusCode(200, results.EmployeesResponse);

            } catch(Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/employees/count")]
        public async Task<IActionResult> GetCount()
        {
            try {
                return base.StatusCode(200, await _queryBus.Ask<EmployeeCounterResponse>(new EmployeeCounterQuery()));
            } catch(Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }



    }
}
