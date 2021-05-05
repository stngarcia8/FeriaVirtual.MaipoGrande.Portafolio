using FeriaVirtual.Domain.Models.Users;
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


        public async Task CreateAsync(User user)
        {
            Task tasks = Task.WhenAll(
                _unitOfWork.Context.OpenContextAsync(),
                _unitOfWork.Context.SaveByStoredProcedureAsync<User>("sp_add_user", user),
                _unitOfWork.Context.SaveByStoredProcedureAsync<Credential>("sp_add_credential", user.GetCredential),
                _unitOfWork.SaveChangesAsync()
                );
            await tasks;
        }


        public async Task Update(User user)
        {
            var tasks = Task.WhenAll(
                _unitOfWork.Context.OpenContextAsync(),
                _unitOfWork.Context.SaveByStoredProcedureAsync<User>("sp_update_user", user),
                _unitOfWork.Context.SaveByStoredProcedureAsync<Credential>("sp_update_credential", user.GetCredential),
                _unitOfWork.SaveChangesAsync()
                );
            await tasks;
        }


        public async Task EnableUser(System.Guid userId)
        {
            _parameters.Add("UserId", userId.ToString());

            var tasks = Task.WhenAll(
                _unitOfWork.Context.OpenContextAsync(),
                _unitOfWork.Context.SaveByStoredProcedureAsync("sp_enable_user", _parameters),
                _unitOfWork.SaveChangesAsync()
                );
            await tasks;
        }


        public async Task DisableUser(System.Guid userId)
        {
            _parameters.Add("UserId", userId.ToString());

            var tasks = Task.WhenAll(
                _unitOfWork.Context.OpenContextAsync(),
                _unitOfWork.Context.SaveByStoredProcedureAsync("sp_disable_user", _parameters),
                _unitOfWork.SaveChangesAsync()
                );
            await tasks;
        }


        public async Task<TResponse> SearchById<TResponse>(System.Guid userId)
            where TResponse : IQueryResponseBase
        {
            _parameters.Clear();
            _parameters.Add("UserId", userId.ToString());

            await _unitOfWork.Context.OpenContextAsync();
            var response = await _unitOfWork.Context.SelectAsync<TResponse>("sp_get_user", _parameters);
            return response.FirstOrDefault();
        }


        public async Task<IEnumerable<TResponse>> SearchByCriteria<TResponse>
             (System.Func<TResponse, bool> filters = null, int pageNumber = 0)
         where TResponse : IQueryResponseBase
        {
            _parameters.Clear();
            _parameters.Add("PageNumber", pageNumber);

            await _unitOfWork.Context.OpenContextAsync();
            var responses= await _unitOfWork.Context.SelectAsync<TResponse>("sp_get_allusers", _parameters);

            if(filters is not null)
                responses = responses.Where(filters);
            return responses.ToList();
        }


        public async Task<int> CountAllUsers()
        {
            await _unitOfWork.Context.OpenContextAsync();
            var response = await _unitOfWork.Context.CountAsync("sp_count_allusers");
            return response;
        }


        public async Task<TResponse> UserUniquenessChecker<TResponse>
            (string username, string dni, string email)
            where TResponse : IQueryResponseBase
        {
            _parameters.Clear();
            _parameters.Add("Username", username);
            _parameters.Add("Dni", dni);
            _parameters.Add("Email", email);

            await _unitOfWork.Context.OpenContextAsync();
            IEnumerable<TResponse> response = await _unitOfWork
                .Context
                .SelectAsync<TResponse>("sp_check_createuser_rules", _parameters);
            return response.FirstOrDefault();
        }


        public async Task<TResponse> UserUniquenessChecker<TResponse>
            (string userId, string username, string dni, string email)
            where TResponse : IQueryResponseBase
        {
            _parameters.Clear();
            _parameters.Add("UserId", userId);
            _parameters.Add("Username", username);
            _parameters.Add("Dni", dni);
            _parameters.Add("Email", email);

            await _unitOfWork.Context.OpenContextAsync();
            IEnumerable<TResponse> response = await _unitOfWork
                .Context
                .SelectAsync<TResponse>("sp_check_updateuser_rules", _parameters);
            return response.FirstOrDefault();
        }


        public async Task ChangePasswordAsync
            (string userId, string password)
        {
            _parameters.Clear();
            _parameters.Add("UserId", userId);
            _parameters.Add("Password", password);

            var tasks = Task.WhenAll(
                _unitOfWork.Context.OpenContextAsync(),
                _unitOfWork.Context.SaveByStoredProcedureAsync("sp_change_password", _parameters),
                _unitOfWork.SaveChangesAsync()
                );
            await tasks;
        }


    }
}
