using FeriaVirtual.Application.Services.Signin.Queries;

namespace Application.Test.Users
{
    public class SigninMother
    {
        public static SigninQuery GetValidSigninQuery() =>
            new("user.test", "a55d3ef664c94df0c32f44bc299d3e4180df61e8");

        public static SigninQuery GetNullSigninQuery() =>
            null;


    }
}
