using FeriaVirtual.Api.Local.SeedWork.Validations;
using FeriaVirtual.Domain.SeedWork.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FeriaVirtual.Api.Local.Controllers.Users.Create
{

    [ApiController]
    public class CreateUserController
        : ControllerBase
    {
        private readonly ICommandBus _commandBus;


        public CreateUserController(ICommandBus commandBus)
            => _commandBus = commandBus;


        [HttpPost]
        [Route("api/users/create")]
        public async Task<IActionResult> Post([FromBody] CreateUserRequest request)
        {
            var rules = new CreateUserValidationRules();
            var validator = ValidationRules<CreateUserRequest>.Build(rules, request);
            if(validator.IsFailed())
                return StatusCode(400, validator.ErrorMessage);

            var userCommand = CreateUserMapper.BuildMapper(request).Map();
            try {
                await _commandBus.DispatchAsync(userCommand);
                return StatusCode(201, $"Usuario {request.Firstname} {request.Lastname} creado correctamente.");

            } catch(System.Exception ex) {
                return BadRequest(ex.Message);
            }
        }


    }
}
