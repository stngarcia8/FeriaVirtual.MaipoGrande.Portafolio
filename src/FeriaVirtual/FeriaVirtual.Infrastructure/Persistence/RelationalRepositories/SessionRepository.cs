using System.Collections.Generic;
using System.Linq;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork;
using FeriaVirtual.Infrastructure.Persistence.OracleContext;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration;
using FeriaVirtual.Infrastructure.SeedWork;

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
            where TViewModel : IViewModelBase
        {
            _parameters.Clear();
            _parameters.Add("Username", username);
            _parameters.Add("Password", password);
            return _unitOfWork.Context.Select<TViewModel>("sp_signin_user", _parameters).FirstOrDefault();
        }


    }
}
