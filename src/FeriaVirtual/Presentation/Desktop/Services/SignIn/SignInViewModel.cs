using FeriaVirtual.App.Desktop.SeedWork;

namespace FeriaVirtual.App.Desktop.Services.SignIn
{
    public class SignInViewModel
        : IViewModelBase
    {
        public string FullName { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public int ProfileId { get; set; }
        public int IsActive { get; set; }


        public SignInViewModel() { }

        public override string ToString() =>
            FullName;


    }
}
