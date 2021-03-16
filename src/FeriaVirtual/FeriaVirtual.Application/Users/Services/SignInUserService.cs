using FeriaVirtual.Application.Users.Dto;
using FeriaVirtual.Application.Users.Exceptions;
using FeriaVirtual.Application.Users.Interfaces;
using FeriaVirtual.Application.Users.ViewModels;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;

namespace FeriaVirtual.Application.Users.Services
{
    public class SignInUserService
        : ISignInUserService
    {
        private readonly ISessionRepository _repository;

        public SignInUserService(ISessionRepository repository)
        {
            _repository = repository;
        }

        public UserSignInViewModel SignIn(SignInUserDto data)
        {
            if (data is null)
                throw new InvalidUserSigninServiceException("Credenciales de usuario inválidas.");
            var userSigninData = new SignInData(data.Username, data.Password);
            return ValidateSigninResults(userSigninData);
        }

        private UserSignInViewModel ValidateSigninResults(SignInData signIn)
        {
            var userData = _repository.SignIn<UserSignInViewModel>(signIn.Username, signIn.Password);
            if (userData is null)
                throw new InvalidUserSigninServiceException("Usuario no tiene cuenta registrada en Feria Virtual.");
            if (userData.IsActive.Equals(0))
                throw new InvalidUserSigninServiceException("Cuenta de usuario inhabilitada, comunique este inconveniente al administrador del sistema.");
            return userData;
        }


    }
}
