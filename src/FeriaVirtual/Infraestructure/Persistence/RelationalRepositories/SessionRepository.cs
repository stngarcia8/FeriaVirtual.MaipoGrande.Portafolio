using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;
using FeriaVirtual.Infrastructure.Persistence.OracleContext;
using FeriaVirtual.Infrastructure.Persistence.OracleContext.Configuration;
using FeriaVirtual.Infrastructure.SeedWork;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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


        public async Task<TResponse> SignIn<TResponse>
            (string username, string password)
            where TResponse : IQueryResponseBase
        {
            _parameters.Clear();
            _parameters.Add("Username", username);
            _parameters.Add("Password", password);

            await _unitOfWork.Context.OpenContextAsync();
            IEnumerable<TResponse> response= await _unitOfWork.Context.SelectAsync<TResponse>("sp_signin_user", _parameters);
            return response.FirstOrDefault();
        }


    }
}
