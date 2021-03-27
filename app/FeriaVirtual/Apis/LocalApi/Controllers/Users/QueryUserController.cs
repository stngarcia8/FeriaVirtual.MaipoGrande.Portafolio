using FeriaVirtual.Application.Users.Queries.Counter;
using FeriaVirtual.Application.Users.Queries.SearchAll;
using FeriaVirtual.Application.Users.Queries.SearchById;
using FeriaVirtual.Domain.SeedWork.Query;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FeriaVirtual.Api.Local.Controllers.Users
{
    [ApiController]
    public class QueryUserController
        : ControllerBase
    {
        private readonly IQueryBus _queryBus;


        public QueryUserController(IQueryBus queryBus) =>
            _queryBus = queryBus;


        [HttpGet]
        [Route("api/users/{userid}")]
        public IActionResult GetById(string userid)
        {
            try {
                var query = new SearchUserByIdQuery(userid);
                var result = _queryBus.Ask<SearchUserByIdResponse>(query);
                return StatusCode(200, result);

            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/users/all/{pageNumber}")]
        public IActionResult GetAll(int pageNumber = 0)
        {
            try {
                var query = new SearchAllUserQuery(pageNumber);
                SearchAllUsersResponse results = _queryBus.Ask<SearchAllUsersResponse>(query);
                return StatusCode(200, results.AllUsers);
            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/users/count")]
        public IActionResult GetCount()
        {
            try {
                var results = _queryBus.Ask<UserCounterResponse>(new UserCounterQuery());
                return StatusCode(200, results);
            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }



    }
}
