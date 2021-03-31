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


        public TResponse SignIn<TResponse>
            (string username, string password)
            where TResponse : IQueryResponseBase
        {
            _parameters.Clear();
            _parameters.Add("Username", username);
            _parameters.Add("Password", password);
            var result = _unitOfWork.Context.Select<TResponse>("sp_signin_user", _parameters).FirstOrDefault();
            return result;
        }


    }
}
