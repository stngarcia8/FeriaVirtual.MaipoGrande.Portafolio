using System;

namespace FeriaVirtual.App.Desktop.Services.Employees.Dto
{
    public class UpdateUserDto
    {
        public string UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Dni { get; set; }
        public int ProfileId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int IsActive { get; set; }


        public UpdateUserDto() { }


    }
}
