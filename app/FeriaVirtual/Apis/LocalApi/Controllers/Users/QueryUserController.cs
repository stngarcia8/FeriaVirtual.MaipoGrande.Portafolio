using FeriaVirtual.Api.Local.Models.Dto;
using FeriaVirtual.Application.Users.Queries.Counter;
using FeriaVirtual.Application.Users.Queries.SearchBycriteria;
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
                var result = _queryBus.Ask<SearchUserByIdResponse>(new SearchUserByIdQuery(userid));
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
                SearchUserByCriteriaQuery query = new("search_all", "", pageNumber);
                SearchUsersByCriteriaResponse results = _queryBus.Ask<SearchUsersByCriteriaResponse>(query);
                return StatusCode(200, results.UsersResponse);

            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/users/searchbycriteria/{searchtype}/{searchvalue}/{pagenumber}")]
        public IActionResult GetByCriteria(string  searchtype, string searchvalue, int pagenumber)
        {
            try {
                SearchUserByCriteriaQuery query = new(searchtype, searchvalue, pagenumber);
                var results = _queryBus.Ask<SearchUsersByCriteriaResponse>(query);
                return StatusCode(200, results.UsersResponse);

            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/users/count")]
        public IActionResult GetCount()
        {
            try {
                return base.StatusCode(200, _queryBus.Ask<UserCounterResponse>(new UserCounterQuery()));

            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }



    }
}
