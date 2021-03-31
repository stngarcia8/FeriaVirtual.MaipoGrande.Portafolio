using FeriaVirtual.Domain.Models.Users;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;
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


        public TResponse SearchById<TResponse>(Guid userId)
            where TResponse : IQueryResponseBase
        {
            _parameters.Clear();
            _parameters.Add("UserId", userId.ToString());
            return _unitOfWork.Context.Select<TResponse>("sp_get_user", _parameters).FirstOrDefault();
        }


        public IEnumerable<TResponse> SearchByCriteria<TResponse>
             (Func<TResponse, bool> filters = null, int pageNumber=0)
         where TResponse : IQueryResponseBase
        {
            _parameters.Clear();
            _parameters.Add("PageNumber", pageNumber);
            IEnumerable<TResponse> results = _unitOfWork.Context.Select<TResponse>("sp_get_allusers", _parameters);
            if (filters != null)
                results = results.Where(filters);
            return results.ToList();
        }

        public int CountAllUsers() =>
            _unitOfWork.Context.Count("sp_count_allusers");


    }
}
