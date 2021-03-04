namespace FeriaVirtual.Application.Users.Dto
{
    public class CreateUserDto
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Dni { get; set; }
        public int ProfileId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public CreateUserDto() { }


    }
}
