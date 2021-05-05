using FeriaVirtual.Api.Local.SeedWork;

namespace FeriaVirtual.Api.Local.Controllers.Users.ChangePassword
{
    public class ChangeUserPasswordRequest
                : IRequest
    {
        public System.Guid UserId { get; set; }
        public string Password { get; set; }


        public ChangeUserPasswordRequest() { }


    }
}
