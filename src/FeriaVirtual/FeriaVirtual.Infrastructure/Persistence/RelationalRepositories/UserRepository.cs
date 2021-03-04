using System;
using System.Collections.Generic;
using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Infrastructure.Persistence.OracleContext;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration;

namespace FeriaVirtual.Infrastructure.Persistence.RelationalRepositories
{
    public class UserRepository
        : IUserRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserRepository() =>
            _unitOfWork = new UnitOfWork(ContextManager.BuildContext(RelationalConfig.Build()));

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
            var parameters = new Dictionary<string, object> {
                {"UserId", userId.ToString() }
            };
            _unitOfWork.Context.SaveByStoredProcedure("sp_enable_user", parameters);
            _unitOfWork.SaveChanges();
        }

        public void DisableUser(Guid userId)
        {
            var parameters = new Dictionary<string, object> {
                {"UserId", userId.ToString() }
            };
            _unitOfWork.Context.SaveByStoredProcedure("sp_disable_user", parameters);
            _unitOfWork.SaveChanges();
        }


    }
}
