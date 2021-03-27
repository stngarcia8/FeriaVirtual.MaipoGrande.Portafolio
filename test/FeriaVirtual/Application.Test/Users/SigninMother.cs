using FeriaVirtual.Application.Users.Queries.Signin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Test.Users
{
    public class SigninMother
    {
        public static UserSigninQuery GetValidSigninQuery() => 
            new("user.test", "a55d3ef664c94df0c32f44bc299d3e4180df61e8");

        public static UserSigninQuery GetNullSigninQuery() =>
            null;


    }
}
