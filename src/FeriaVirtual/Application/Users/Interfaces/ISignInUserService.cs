using FeriaVirtual.Application.Users.Dtos;
using FeriaVirtual.Application.Users.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Users.Interfaces
{
    public interface ISignInUserService
    {
        UserSignInViewModel SignIn(SignInUserDto signInData);


    }
}
