using System;

namespace FeriaVirtual.Application.Users.Dtos
{
    public class EnableOrDisableUserDto
    {
        public Guid UserId { get; protected set; }


        public EnableOrDisableUserDto(string userId) =>
            UserId = new Guid(userId);


    }
}
