using FeriaVirtual.Api.Local.Models.Dto;
using FeriaVirtual.Application.Users.Services.Create;
using FeriaVirtual.Domain.SeedWork.Commands;
using Microsoft.AspNetCore.Mvc;
using System;


namespace FeriaVirtual.Api.Local.Controllers.Users
{

    [ApiController]
    public class CreateUserController
        : ControllerBase
    {
        private readonly ICommandBus _commandBus;


        public CreateUserController(ICommandBus commandBus) =>
            _commandBus = commandBus;


        [HttpPost]
        [Route("api/users/create")]
        public IActionResult Post([FromBody] CreateUserDto userDto)
        {
            try {
                var userCommand = CreateUserCommandBuilder.GetInstance()
                    .Firstname(userDto.Firstname)
                    .Lastname(userDto.Lastname)
                    .Dni(userDto.Dni)
                    .ProfileId(userDto.ProfileId)
                    .Username(userDto.Username)
                    .Password(userDto.Password)
                    .Email(userDto.Email)
                    .Build();
                _commandBus.Dispatch(userCommand);
                return StatusCode(201, $"Usuario {userDto.Firstname} {userDto.Lastname} creado correctamente.");

            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


    }
}
