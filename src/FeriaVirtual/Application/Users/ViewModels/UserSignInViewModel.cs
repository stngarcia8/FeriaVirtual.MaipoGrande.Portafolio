using FeriaVirtual.Domain.SeedWork;

namespace FeriaVirtual.Application.Users.ViewModels
{
    public class UserSignInViewModel
        : IViewModelBase
    {
        public string FullName { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public int ProfileId { get; set; }
        public int IsActive { get; set; }


        public UserSignInViewModel() { }

        public override string ToString() =>
            FullName;


    }
}
