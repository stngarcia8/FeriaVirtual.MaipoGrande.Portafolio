using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Signin.Queries
{
    public class SigninQueryHandler
        : IQueryHandler<SigninQuery, SigninResponse>
    {
        private readonly ISessionRepository _repository;


        public SigninQueryHandler(ISessionRepository repository)
        {
            _repository = repository;
        }


        public async Task<SigninResponse> Handle(SigninQuery query)
        {
            if (query is null) {
                throw new InvalidSigninServiceException("Credenciales de usuario inválidas.");
            }
            return await ValidateResult(query);
        }


        private async Task<SigninResponse> ValidateResult(SigninQuery userQuery)
        {
            var result = await _repository.SignIn<SigninResponse>(userQuery.Username, userQuery.Password);
            if (result is null)
                throw new InvalidSigninServiceException("Usuario no esta registrado en Feria virtual.");
            if (result.IsActive < 0 || result.IsActive > 2)
                throw new InvalidSigninServiceException("Usuario no tiene acceso a Feria virtual.");
            return result;
        }


    }
}
