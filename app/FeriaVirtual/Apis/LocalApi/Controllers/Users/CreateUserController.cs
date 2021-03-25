using FeriaVirtual.Application.Users.Dtos;
using FeriaVirtual.Application.Users.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;


namespace FeriaVirtual.Api.Local.Controllers.Users
{

    [ApiController]
    public class CreateUserController
        : ControllerBase
    {
        private readonly ICreateUserService _createUserService;


        public CreateUserController(ICreateUserService createUserService) =>
            _createUserService = createUserService;


        [HttpPost]
        [Route("api/users/create")]
        public IActionResult Post([FromBody] CreateUserDto userDto)
        {
            try {
                _createUserService.Create(userDto);
                return StatusCode(201, $"Usuario {userDto.Firstname} {userDto.Lastname} creado correctamente.");
            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


    }
}
