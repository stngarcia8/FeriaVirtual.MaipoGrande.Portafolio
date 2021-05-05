using FeriaVirtual.Api.Local.SeedWork.Validations;
using FeriaVirtual.Domain.SeedWork.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FeriaVirtual.Api.Local.Controllers.Users.ChangePassword
{
    [ApiController]
    public class ChangeUserPasswordController
        : ControllerBase
    {
        private readonly ICommandBus _commandBus;


        public ChangeUserPasswordController(ICommandBus commandBus)
            => _commandBus = commandBus;


        [HttpPut]
        [Route("api/users/changepassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangeUserPasswordRequest request)
        {
            var rules = new ChangeUserPasswordValidationRule();
            var validator = ValidationRules<ChangeUserPasswordRequest>.Build(rules, request);
            if(validator.IsFailed())
                return StatusCode(400, validator.ErrorMessage);

            try {
                var command = ChangeUserPasswordMapper.BuildMapper(request).Map();
                await _commandBus.DispatchAsync(command);
                return StatusCode(201, "Cambio de contraseña realizado correctamente.");

            } catch(Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


    }
}
