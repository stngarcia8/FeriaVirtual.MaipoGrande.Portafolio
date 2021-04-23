using FeriaVirtual.Api.Local.SeedWork;

namespace FeriaVirtual.Api.Local.Controllers.Users.Create
{
    public class CreateUserRequest
        : IRequest
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Dni { get; set; }
        public int ProfileId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public CreateUserRequest() { }



    }
}
