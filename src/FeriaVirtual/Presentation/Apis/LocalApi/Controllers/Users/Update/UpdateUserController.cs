using FeriaVirtual.Api.Local.SeedWork.Validations;
using FeriaVirtual.Domain.SeedWork.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FeriaVirtual.Api.Local.Controllers.Users.Update
{

    [ApiController]
    public class UpdateUserController
        : ControllerBase
    {
        private readonly ICommandBus _commandBus;


        public UpdateUserController(ICommandBus commandBus)
            => _commandBus = commandBus;


        [HttpPut]
        [Route("api/users/update")]
        public async Task<IActionResult> Put([FromBody] UpdateUserRequest request)
        {
            var rules = new UpdateUserValidationRule();
            var validator = ValidationRules<UpdateUserRequest>.Build(rules, request);
            if(validator.IsFailed())
                return StatusCode(400, validator.ErrorMessage);

            var userCommand = UpdateUserMapper.BuildMapper(request).Map();
            try {
                await _commandBus.DispatchAsync(userCommand);
                string fullname = $"{request.Firstname} {request.Lastname}";
                return StatusCode(200, $"El usuario {fullname} fue actualizado correctamente");

            } catch(Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


    }
}
