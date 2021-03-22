using FeriaVirtual.Domain.SeedWork;

namespace FeriaVirtual.Application.Users.ViewModels
{
    public class UserListViewModel
        : IViewModelBase
    {
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Dni { get; set; }
        public string ProfileName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string UserStatus { get; set; }


        public UserListViewModel() { }


        public override string ToString() =>
            FullName;


    }
}
