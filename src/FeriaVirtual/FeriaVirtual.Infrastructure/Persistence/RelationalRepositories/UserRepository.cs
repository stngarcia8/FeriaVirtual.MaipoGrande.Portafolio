using System;
using System.Collections.Generic;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork;
using FeriaVirtual.Infrastructure.Persistence.OracleContext;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration;

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
            _parameters.Clear();
            _parameters.Add("UserId", userId.ToString());
            _unitOfWork.Context.SaveByStoredProcedure("sp_enable_user", _parameters);
            _unitOfWork.SaveChanges();
        }

        public void DisableUser(Guid userId)
        {
            _parameters.Clear();
            _parameters.Add("UserId", userId.ToString());
            _unitOfWork.Context.SaveByStoredProcedure("sp_disable_user", _parameters);
            _unitOfWork.SaveChanges();
        }

        public TViewModel SearchById<TViewModel>(Guid userId)
            where TViewModel : IViewModelBase
        {
            _parameters.Clear();
            _parameters.Add("UserId", userId.ToString());
            IList<TViewModel> results = _unitOfWork.Context.Select<TViewModel>("sp_get_user", _parameters);
            return results[0];
        }

        public IList<TViewModel> SearchAll<TViewModel>(int pageNumber)
            where TViewModel : IViewModelBase
        {
            _parameters.Clear();
            _parameters.Add("PageNumber", pageNumber);
            IList<TViewModel> results = _unitOfWork.Context.Select<TViewModel>("sp_get_alluser", _parameters);
            return results;
        }

    }
}
