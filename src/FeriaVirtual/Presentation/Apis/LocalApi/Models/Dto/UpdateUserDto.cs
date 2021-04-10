using System;

namespace FeriaVirtual.Api.Local.Models.Dto
{
    public class UpdateUserDto
    {
        public Guid UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Dni { get; set; }
        public int ProfileId { get; set; }
        public Guid CredentialId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int IsActive { get; set; }


        public UpdateUserDto() { }


    }
}
