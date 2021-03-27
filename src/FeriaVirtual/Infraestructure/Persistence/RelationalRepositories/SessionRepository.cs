using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;
using FeriaVirtual.Infrastructure.Persistence.OracleContext;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration;
using FeriaVirtual.Infrastructure.SeedWork;
using System.Collections.Generic;
using System.Linq;

namespace FeriaVirtual.Infrastructure.Persistence.RelationalRepositories
{
    public class SessionRepository
        : ISessionRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly Dictionary<string, object> _parameters;


        public SessionRepository()
        {
            _unitOfWork = new UnitOfWork(ContextManager.BuildContext(RelationalConfig.Build()));
            _parameters = new Dictionary<string, object>();
        }


        public TViewModel SignIn<TViewModel>
            (string username, string password)
            where TViewModel : IQueryResponseBase
        {
            _parameters.Clear();
            _parameters.Add("Username", username);
            _parameters.Add("Password", password);
            var result = _unitOfWork.Context.Select<TViewModel>("sp_signin_user", _parameters).FirstOrDefault();
            return result;
        }


    }
}
