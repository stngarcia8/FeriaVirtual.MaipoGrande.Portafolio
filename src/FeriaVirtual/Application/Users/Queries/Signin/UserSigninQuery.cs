using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Users.Queries.Signin
{
    public class UserSigninQuery
        : Query
    {
        public string Username { get; protected set; }
        public string Password { get; protected set; }


        public UserSigninQuery(string username, string password)
        {
            Username = username;
            Password = password;
        }


    }
}
