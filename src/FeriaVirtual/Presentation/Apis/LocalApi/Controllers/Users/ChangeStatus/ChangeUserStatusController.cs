using FeriaVirtual.Api.Local.SeedWork.Validations;
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


        [HttpPut]
        [Route("api/users/changestatus")]
        public async Task<IActionResult> ChangeStatus([FromBody] ChangeUserStatusRequest request)
        {
            var rules = new ChangeUserStatusValidationRule();
            var validator = ValidationRules<ChangeUserStatusRequest>.Build(rules, request);
            if(validator.IsFailed())
                return StatusCode(400, validator.ErrorMessage);

            try {
                var command = ChangeUserStatusMapper.BuildMapper(request).Map();
                await _commandBus.DispatchAsync(command);
                var status = (request.Status.Equals(1)?"habilitado":"inhabilitado");
                return StatusCode(201, "El usuario fue {status}.");

            } catch(Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


    }
}
