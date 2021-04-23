using FeriaVirtual.App.Desktop.SeedWork;

namespace FeriaVirtual.App.Desktop.Services.Employees.ViewModels
{
    public class EmployeesViewModel
        : IViewModelBase
    {
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Dni { get; set; }
        public string ProfileName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string UserStatus { get; set; }


        public EmployeesViewModel() { }


    }
}
