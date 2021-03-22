using FeriaVirtual.Domain.SeedWork;
using System;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.Models.Users.Interfaces
{
    public interface IUserRepository
    {
        void Create(User user);
        void Update(User user);
        void EnableUser(Guid userId);
        void DisableUser(Guid userId);

        TViewModel SearchById<TViewModel>(Guid userId)
            where TViewModel : IViewModelBase;

        IList<TViewModel> SearchAll<TViewModel>(int pageNumber = 1)
            where TViewModel : IViewModelBase;

        IList<TViewModel> SearchEnableUsers<TViewModel>(int pageNumber = 1)
            where TViewModel : IViewModelBase;

        IList<TViewModel> SearchDisableUsers<TViewModel>(int pageNumber = 0)
            where TViewModel : IViewModelBase;

        IList<TViewModel> SearchByCriteria<TViewModel>
            (Func<TViewModel, bool> filters = null)
            where TViewModel : IViewModelBase;

        int CountAllUsers();
        int CountEnabledUsers();
        int CountDisabledUsers();


    }
}
