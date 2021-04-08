using FeriaVirtual.Domain.SeedWork.Commands;

namespace FeriaVirtual.Application.Services.Users.Create
{
    public class CreateUserCommand
        : Command
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Dni { get; set; }
        public int ProfileId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public CreateUserCommand() { }


    }
}
