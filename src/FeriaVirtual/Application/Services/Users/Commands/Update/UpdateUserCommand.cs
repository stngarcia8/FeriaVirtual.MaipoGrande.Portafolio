using FeriaVirtual.Domain.SeedWork.Commands;
using System;

namespace FeriaVirtual.Application.Services.Users.Commands.Update
{
    public class UpdateUserCommand
        : Command
    {
        public Guid UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Dni { get; set; }
        public int ProfileId { get; set; }

        public Guid CredentialId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int IsActive { get; set; }


        public UpdateUserCommand() { }


    }
}
