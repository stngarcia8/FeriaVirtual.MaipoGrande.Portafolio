using System;

namespace FeriaVirtual.Application.Users.Dtos
{
    public class UseridDto
    {
        public Guid UserId { get; protected set; }


        public UseridDto(string userId) =>
            UserId = new Guid(userId);


    }
}
