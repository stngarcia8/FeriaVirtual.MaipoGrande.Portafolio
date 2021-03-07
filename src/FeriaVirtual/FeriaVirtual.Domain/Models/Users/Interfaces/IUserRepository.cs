using System;
using System.Collections.Generic;
using FeriaVirtual.Domain.SeedWork;

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
        IList<TViewModel> SearchAll<TViewModel>(int pageNumber)
            where TViewModel : IViewModelBase;


    }
}
