using FeriaVirtual.Application.Users.Dto;
using FeriaVirtual.Application.Users.ViewModels;

namespace FeriaVirtual.Application.Users.Interfaces
{
    public interface ISignInUserService
    {
        UserSignInViewModel SignIn(SignInUserDto signInData);


    }
}
