using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork;
using FeriaVirtual.Infrastructure.Persistence.OracleContext;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration;
using FeriaVirtual.Infrastructure.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FeriaVirtual.Infrastructure.Persistence.RelationalRepositories
{
    public class UserRepository
        : IUserRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly Dictionary<string, object> _parameters;


        public UserRepository()
        {
            _unitOfWork = new UnitOfWork(ContextManager.BuildContext(RelationalConfig.Build()));
            _parameters = new Dictionary<string, object>();
        }


        public void Create(User user)
        {
            _unitOfWork.Context.SaveByStoredProcedure<Credential>("sp_add_credential", user.GetCredential);
            _unitOfWork.Context.SaveByStoredProcedure<User>("sp_add_user", user);
            _unitOfWork.SaveChanges();
        }


        public void Update(User user)
        {
            _unitOfWork.Context.SaveByStoredProcedure<Credential>("sp_update_credential", user.GetCredential);
            _unitOfWork.Context.SaveByStoredProcedure<User>("sp_update_user", user);
            _unitOfWork.SaveChanges();
        }


        public void EnableUser(Guid userId)
        {
            _parameters.Add("UserId", userId.ToString());
            _unitOfWork.Context.SaveByStoredProcedure("sp_enable_user", _parameters);
            _unitOfWork.SaveChanges();
        }


        public void DisableUser(Guid userId)
        {
            _parameters.Add("UserId", userId.ToString());
            _unitOfWork.Context.SaveByStoredProcedure("sp_disable_user", _parameters);
            _unitOfWork.SaveChanges();
        }


        public TViewModel SearchById<TViewModel>
            (Guid userId)
            where TViewModel : IViewModelBase
        {
            _parameters.Clear();
            _parameters.Add("UserId", userId.ToString());
            return _unitOfWork.Context.Select<TViewModel>("sp_get_user", _parameters).FirstOrDefault();
        }


        public IList<TViewModel> SearchAll<TViewModel>(int pageNumber = 0)
            where TViewModel : IViewModelBase
        {
            _parameters.Clear();
            _parameters.Add("PageNumber", pageNumber);
            return _unitOfWork.Context.Select<TViewModel>("sp_get_allusers", _parameters)
                .ToList();
        }


        public IList<TViewModel> SearchEnableUsers<TViewModel>(int pageNumber = 1)
            where TViewModel : IViewModelBase =>
            _unitOfWork.Context.Select<TViewModel>("sp_get_enableusers", _parameters)
            .ToList();


        public IList<TViewModel> SearchDisableUsers<TViewModel>(int pageNumber = 1)
            where TViewModel : IViewModelBase =>
            _unitOfWork.Context.Select<TViewModel>("sp_get_disableusers", _parameters)
            .ToList();

        public IList<TViewModel> SearchByCriteria<TViewModel>
            (Func<TViewModel, bool> filters = null)
        where TViewModel : IViewModelBase
        {
            _parameters.Clear();
            _parameters.Add("PageNumber", 0);
            IEnumerable<TViewModel> results = _unitOfWork.Context.Select<TViewModel>("sp_get_allusers", _parameters);
            if (filters != null)
                results = results.Where(filters);
            return results.ToList();
        }

        public int CountAllUsers() =>
            _unitOfWork.Context.Count("sp_count_allusers");

        public int CountEnabledUsers() =>
            _unitOfWork.Context.Count("sp_count_enabledusers");

        public int CountDisabledUsers() =>
            _unitOfWork.Context.Count("sp_count_disabledusers");


    }
}
