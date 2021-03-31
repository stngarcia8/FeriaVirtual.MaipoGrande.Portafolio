using FeriaVirtual.Api.Local.Models.Dto;
using FeriaVirtual.Application.Users.Queries.Signin;
using FeriaVirtual.Domain.SeedWork.Query;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FeriaVirtual.Api.Local.Controllers.Users
{
    [ApiController]
    public class SigninUserController
        : ControllerBase
    {
        private readonly IQueryBus _queryBus;


        public SigninUserController(IQueryBus queryBus) =>
            _queryBus = queryBus;


        [HttpPost]
        [Route("api/sign_in")]
        public IActionResult SignIn([FromBody] SignInUserDto userDto)
        {
            try {
                var userQuery = new UserSigninQuery(userDto.Username, userDto.Password);
                var result = _queryBus.Ask<UserSigninResponse>(userQuery);
                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


    }
}
