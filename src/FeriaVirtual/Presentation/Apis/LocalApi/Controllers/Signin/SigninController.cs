using FeriaVirtual.Api.Local.SeedWork.Validations;
using FeriaVirtual.Application.Services.Signin.Queries;
using FeriaVirtual.Domain.SeedWork.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FeriaVirtual.Api.Local.Controllers.Signin
{
    [ApiController]
    public class SigninController
        : ControllerBase
    {
        private readonly IQueryBus _queryBus;


        public SigninController(IQueryBus queryBus)
            => _queryBus = queryBus;


        [HttpPost]
        [Route("api/signin")]
        public async Task<IActionResult> SignIn([FromBody] SigninRequest request)
        {
            var rules = new SigninValidationRules();
            var validator = ValidationRules<SigninRequest>.Build(rules, request);
            if(validator.IsFailed())
                return StatusCode(400, validator.ErrorMessage);

            try {
                var query = SigninMapper.BuildMapper(request).Map();
                var result = await _queryBus.Ask<SigninResponse>(query);
                return StatusCode(200, result);

            } catch(Exception ex) {
                return StatusCode(400, ex.Message);
            }
        }


    }
}
