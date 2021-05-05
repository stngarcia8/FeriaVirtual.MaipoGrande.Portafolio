using FeriaVirtual.Domain.SeedWork.Commands;

namespace FeriaVirtual.Application.Services.Users.Commands.ChangePassword
{
    public class ChangeUserPasswordCommand
        : Command
    {
        public System.Guid UserId { get; protected set; }
        public string Password { get; protected set; }


        public ChangeUserPasswordCommand
            (System.Guid userId, string password)
        {
            UserId = userId;
            Password = password;
        }


    }
}
