using FeriaVirtual.Application.Users.Dtos;
using FeriaVirtual.Application.Users.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FeriaVirtual.Api.Local.Controllers.Users
{
    [ApiController]
    public class SigninUserController
        : ControllerBase
    {
        private readonly ISignInUserService _userService;


        public SigninUserController(ISignInUserService userService) =>
            _userService = userService;


        [HttpPost]
        [Route("api/sign_in")]
        public IActionResult SignIn([FromBody] SignInUserDto userDto)
        {
            try {
                var result = _userService.SignIn(userDto);
                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


    }
}
