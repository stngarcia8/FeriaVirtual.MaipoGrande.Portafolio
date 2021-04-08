using FeriaVirtual.Domain.SeedWork.Commands;
using System;

namespace FeriaVirtual.Application.Users.Commands.ChangeStatus
{
    public class ChangeUserStatusCommand
        : Command
    {
        public Guid UserId { get; protected set; }
        public int IsActive { get; protected set; }


        public ChangeUserStatusCommand(string userId, int isActive)
        {
            UserId = new Guid(userId);
            IsActive = isActive;
        }
            


    }
}
