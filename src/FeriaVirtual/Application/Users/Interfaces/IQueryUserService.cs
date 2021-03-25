using FeriaVirtual.Application.Users.ViewModels;
using System.Collections.Generic;

namespace FeriaVirtual.Application.Users.Interfaces
{
    public interface IQueryUserService
    {
        UserViewModel SearchById(string userId);
        IEnumerable<UserListViewModel> SearchAll(int pageNumber = 0);
        int Count();


    }
}
