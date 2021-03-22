using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Users.Dtos
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
