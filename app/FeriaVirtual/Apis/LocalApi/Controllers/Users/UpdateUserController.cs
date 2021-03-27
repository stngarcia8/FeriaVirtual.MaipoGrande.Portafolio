﻿using FeriaVirtual.Application.Users.Commands.Update;
using FeriaVirtual.Application.Users.Dtos;
using FeriaVirtual.Domain.SeedWork.Commands;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FeriaVirtual.Api.Local.Controllers.Users
{

    [ApiController]
    public class UpdateUserController
        : ControllerBase
    {
        private readonly ICommandBus _commandBus;


        public UpdateUserController(ICommandBus commandBus) =>
            _commandBus = commandBus;


        [HttpPut]
        [Route("api/users/update")]
        public IActionResult Put([FromBody] UpdateUserDto userDto)
        {
            try {
                var command = UpdateUserCommandBuilder.GetInstance()
                    .UserId(userDto.UserId.ToString())
                    .Firstname(userDto.Firstname)
                    .Lastname(userDto.Lastname)
                    .Dni(userDto.Dni)
                    .ProfileId(userDto.ProfileId)
                    .CredentialId(userDto.CredentialId.ToString())
                    .Username(userDto.Username)
                    .Password(userDto.Password)
                    .Email(userDto.Email)
                    .IsActive(userDto.IsActive)
                    .Build();
                _commandBus.Dispatch(command);
                return StatusCode(200, $"El usuario {userDto.Firstname} {userDto.Lastname} fue actualizado correctamente");
            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


    }
}