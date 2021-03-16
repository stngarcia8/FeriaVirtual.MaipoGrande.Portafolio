using System.Collections.Generic;
using FeriaVirtual.Application.Users.ViewModels;

namespace FeriaVirtual.Application.Users.Interfaces
{
    public interface IQueryUserService
    {
        UserViewModel SearchById(string userId);
        IList<UserViewModel> SearchAll(int pageNumber = 0);
        IList<UserViewModel> SearchByCriteria(string filter);
        int CountAllUsers();
        int CountEnabledUser();
        int CountDisabledUser();


    }
}
