using FeriaVirtual.App.Desktop.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.App.Desktop.ViewModels.Users
{
    public class UserSignInViewModel
        :IViewModelBase
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
