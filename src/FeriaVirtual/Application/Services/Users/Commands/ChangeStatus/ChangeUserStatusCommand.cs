using FeriaVirtual.Domain.SeedWork.Commands;


namespace FeriaVirtual.Application.Users.Commands.ChangeStatus
{
    public class ChangeUserStatusCommand
        : Command
    {
        public System.Guid UserId { get; protected set; }
        public int IsActive { get; protected set; }


        public ChangeUserStatusCommand(System.Guid userId, int isActive)
        {
            UserId = userId;
            IsActive = isActive;
        }



    }
}
