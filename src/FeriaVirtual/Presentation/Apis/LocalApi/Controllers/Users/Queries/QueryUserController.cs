using FeriaVirtual.Application.Services.Users.Queries.Counter;
using FeriaVirtual.Application.Services.Users.Queries.SearchBycriteria;
using FeriaVirtual.Application.Services.Users.Queries.SearchById;
using FeriaVirtual.Domain.SeedWork.Query;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FeriaVirtual.Api.Local.Controllers.Users.Queries
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

            } catch(System.Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/users/all/{pageNumber}")]
        public async Task<IActionResult> GetAll(int pageNumber = 0)
        {
            try {
                SearchUserByCriteriaQuery query = new("search_all", "", pageNumber);
                SearchUsersByCriteriaResponse results = await _queryBus.Ask<SearchUsersByCriteriaResponse>(query);
                return StatusCode(200, results.UsersResponse);

            } catch(System.Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/users/searchbycriteria/{searchtype}/{searchvalue}/{pagenumber}")]
        public IActionResult GetByCriteria(string searchtype, string searchvalue, int pagenumber)
        {
            try {
                SearchUserByCriteriaQuery query = new(searchtype, searchvalue, pagenumber);
                var results = _queryBus.Ask<SearchUsersByCriteriaResponse>(query);
                var value = results.Result;
                return StatusCode(200, value.UsersResponse);

            } catch(System.Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/users/count")]
        public IActionResult GetCount()
        {
            try {
                return base.StatusCode(200, _queryBus.Ask<UserCounterResponse>(new UserCounterQuery()));

            } catch(System.Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }



    }
}
