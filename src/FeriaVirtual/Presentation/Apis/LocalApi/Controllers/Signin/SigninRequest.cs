using FeriaVirtual.Api.Local.SeedWork;

namespace FeriaVirtual.Api.Local.Controllers.Signin
{
    public class SigninRequest
        : IRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }


        public SigninRequest() { }


    }
}
