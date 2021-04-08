namespace FeriaVirtual.Application.Services.Users.Create
{
    public class CreateUserCommandBuilder
    {
        private readonly CreateUserCommand _command;


        private CreateUserCommandBuilder() =>
            _command = new CreateUserCommand();

        public static CreateUserCommandBuilder GetInstance() =>
            new();

        public CreateUserCommandBuilder Firstname(string firstname)
        {
            _command.Firstname = firstname;
            return this;
        }

        public CreateUserCommandBuilder Lastname(string lastname)
        {
            _command.Lastname = lastname;
            return this;
        }

        public CreateUserCommandBuilder Dni(string dni)
        {
            _command.Dni = dni;
            return this;
        }

        public CreateUserCommandBuilder ProfileId(int profileid)
        {
            _command.ProfileId = profileid;
            return this;
        }

        public CreateUserCommandBuilder Username(string username)
        {
            _command.Username = username;
            return this;
        }

        public CreateUserCommandBuilder Password(string password)
        {
            _command.Password = password;
            return this;
        }

        public CreateUserCommandBuilder Email(string email)
        {
            _command.Email = email;
            return this;
        }

        public CreateUserCommand Build() =>
            _command;





    }
}
