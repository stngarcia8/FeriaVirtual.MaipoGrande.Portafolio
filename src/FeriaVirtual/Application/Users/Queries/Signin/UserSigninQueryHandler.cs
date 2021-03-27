using FeriaVirtual.Application.Users.Exceptions;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Users.Queries.Signin
{
    public class UserSigninQueryHandler
        : IQueryHandler<UserSigninQuery, UserSigninResponse>
    {
        private readonly ISessionRepository _repository;


        public UserSigninQueryHandler(ISessionRepository repository)
        {
            _repository = repository;
        }


        public UserSigninResponse Handle(UserSigninQuery query)
        {
            if (query is null) {
                throw new InvalidUserSigninServiceException("Credenciales de usuario inválidas.");
            }
            return ValidateResult(query);
        }


        private UserSigninResponse ValidateResult(UserSigninQuery userQuery)
        {
            var result = _repository.SignIn<UserSigninResponse>(userQuery.Username, userQuery.Password);
            if (result is null)
                throw new InvalidUserSigninServiceException("Usuario no esta registrado en Feria virtual.");
            if(result.IsActive<0 || result.IsActive>2)
                throw new InvalidUserSigninServiceException("Usuario no tiene acceso a aplicación de Feria virtual.");
            return result;
        }


    }
}
