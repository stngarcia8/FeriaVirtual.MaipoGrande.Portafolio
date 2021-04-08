using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Users.Commands.Update
{
    public class UpdateUserCommandBuilder
    {
        private readonly UpdateUserCommand _command;


        private UpdateUserCommandBuilder() =>
            _command = new UpdateUserCommand();

        public static UpdateUserCommandBuilder GetInstance() =>
            new();

        public UpdateUserCommandBuilder UserId(string userid)
        {
            _command.UserId = new Guid(userid);
            return this;
        }

        public UpdateUserCommandBuilder Firstname(string firstname)
        {
            _command.Firstname = firstname;
            return this;
        }

        public UpdateUserCommandBuilder Lastname(string lastname)
        {
            _command.Lastname = lastname;
            return this;
        }

        public UpdateUserCommandBuilder Dni(string dni)
        {
            _command.Dni = dni;
            return this;
        }

        public UpdateUserCommandBuilder ProfileId(int profileid)
        {
            _command.ProfileId = profileid;
            return this;
        }

        public UpdateUserCommandBuilder CredentialId(string credentialid)
        {
            _command.CredentialId = new Guid(credentialid);
            return this;
        }

        public UpdateUserCommandBuilder Username(string username)
        {
            _command.Username = username;
            return this;
        }

        public UpdateUserCommandBuilder Password(string password)
        {
            _command.Password = password;
            return this;
        }

        public UpdateUserCommandBuilder Email(string email)
        {
            _command.Email = email;
            return this;
        }

        public UpdateUserCommandBuilder IsActive(int isactive)
        {
            _command.IsActive = isactive;
            return this;
        }

        public UpdateUserCommand Build() =>
            _command;



    }
}
