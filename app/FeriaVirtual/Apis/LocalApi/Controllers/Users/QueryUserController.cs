using FeriaVirtual.Application.Users.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FeriaVirtual.Api.Local.Controllers.Users
{
    [ApiController]
    public class QueryUserController
        : ControllerBase
    {
        private readonly IQueryUserService _userService;


        public QueryUserController(IQueryUserService userService) =>
            _userService = userService;


        [HttpGet]
        [Route("api/users/{userid}")]
        public IActionResult GetById(string userid)
        {
            try {
                var result = _userService.SearchById(userid);
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
                var results = _userService.SearchAll(pageNumber);
                return StatusCode(200, results);
            } catch(Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/users/count")]
        public IActionResult GetCount()
        {
            try {
                var results = _userService.Count();
                return StatusCode(200, results);
            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }



    }
}
