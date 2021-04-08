using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Services.Signin.Queries
{
    public class SigninQuery
        : Query
    {
        public string Username { get; protected set; }
        public string Password { get; protected set; }


        public SigninQuery
            (string username, string password)
        {
            Username = username;
            Password = password;
        }


    }
}
