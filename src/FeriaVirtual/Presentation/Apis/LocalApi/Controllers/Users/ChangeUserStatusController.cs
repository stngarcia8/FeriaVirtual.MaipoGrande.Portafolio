using FeriaVirtual.Application.Users.Commands.ChangeStatus;
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
            _commandBus = commandBus;


        [HttpPatch]
        [Route("api/users/enable/{userid}")]
        public IActionResult Patch(string userid)
        {
            try {
                _commandBus.DispatchAsync(new ChangeUserStatusCommand(userid, 1));
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
                _commandBus.DispatchAsync(new ChangeUserStatusCommand(userid, 0));
                return StatusCode(201, "El usuario fue inhabilitado.");

            } catch (Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


    }
}
