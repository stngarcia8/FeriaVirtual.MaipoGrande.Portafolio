using FeriaVirtual.Application.Users.Commands.ChangeStatus;
using FeriaVirtual.Domain.SeedWork.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FeriaVirtual.Api.Local.Controllers.Users.ChangeStatus
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
        public async Task<IActionResult> EnableUser(string userid)
        {
            var isValidId = Guid.TryParse((string) userid, out var result);
            if(userid is null || !isValidId)
                return StatusCode(400, "Identificador de usuario inválido.");

            try {
                var command = new ChangeUserStatusCommand(result, 1);
                await _commandBus.DispatchAsync(command);
                return StatusCode(201, "El usuario fue habilitado.");

            } catch(Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


        [HttpPatch]
        [Route("api/users/disable/{userid}")]
        public async Task<IActionResult> DisableUser(string userid)
        {
            var isValidId = Guid.TryParse((string) userid, out var result);
            if(userid is null || !isValidId)
                return StatusCode(400, "Identificador de usuario inválido.");

            try {
                var command = new ChangeUserStatusCommand(result, 0);
                await _commandBus.DispatchAsync(command);
                return StatusCode(201, "El usuario fue inhabilitado.");

            } catch(Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


    }
}
