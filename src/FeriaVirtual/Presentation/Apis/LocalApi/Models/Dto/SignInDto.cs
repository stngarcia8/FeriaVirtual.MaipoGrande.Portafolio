namespace FeriaVirtual.Api.Local.Models.Dto
{
    public class SignInDto
    {
        public string Username { get; protected set; }
        public string Password { get; protected set; }


        public SignInDto(string username, string password)
        {
            Username = username;
            Password = password;
        }


    }
}
