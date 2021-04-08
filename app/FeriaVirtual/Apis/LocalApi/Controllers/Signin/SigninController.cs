using FeriaVirtual.Api.Local.Models.Dto;
using FeriaVirtual.Application.Services.Signin.Queries;
using FeriaVirtual.Domain.SeedWork.Query;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FeriaVirtual.Api.Local.Controllers.Signin
{
    [ApiController]
    public class SigninController
        : ControllerBase
    {
        private readonly IQueryBus _queryBus;


        public SigninController(IQueryBus queryBus) =>
            _queryBus = queryBus;


        [HttpPost]
        [Route("api/sign_in")]
        public IActionResult SignIn([FromBody] SignInDto userDto)
        {
            try {
                var userQuery = new SigninQuery(userDto.Username, userDto.Password);
                var result = _queryBus.Ask<SigninResponse>(userQuery);
                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


    }
}
