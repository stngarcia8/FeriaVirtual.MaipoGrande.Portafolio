using FeriaVirtual.Application.Users.Commands.ChangeStatus;
using FeriaVirtual.Application.Users.Dtos;
using FeriaVirtual.Application.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Commands;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FeriaVirtual.Api.Local.Controllers.Users
{
    [ApiController]
    public class ChangeUserStatusController
        : ControllerBase
    {
        private readonly ICommandBus _commandBus;


        public ChangeUserStatusController(ICommandBus commandBus) =>
            _commandBus= commandBus;


        [HttpPatch]
        [Route("api/users/enable/{userid}")]
        public IActionResult Patch(string userid)
        {
            try {
                var command= new ChangeUserStatusCommand(userid, 1);
                _commandBus.Dispatch(command);
                return StatusCode(201, "El usuario fue habilitado.");
            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


        [HttpPatch]
        [Route("api/users/disable/{userid}")]
        public IActionResult DisableUser(string userid)
        {
            try {
                var command = new ChangeUserStatusCommand(userid, 0);
                _commandBus.Dispatch(command);
                return StatusCode(201, "El usuario fue inhabilitado.");
            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


    }
}
