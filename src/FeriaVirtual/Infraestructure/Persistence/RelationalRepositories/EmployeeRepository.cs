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
    public class EmployeeRepository
        : IEmployeeRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly Dictionary<string, object> _parameters;


        public EmployeeRepository()
        {
            _unitOfWork = new UnitOfWork(ContextManager.BuildContext(RelationalConfig.Build()));
            _parameters = new Dictionary<string, object>();
        }


        public async Task<TResponse> SearchById<TResponse>(System.Guid userId)
            where TResponse : IQueryResponseBase
        {
            _parameters.Clear();
            _parameters.Add("UserId", userId.ToString());

            await _unitOfWork.Context.OpenContextAsync();
            IEnumerable<TResponse> response = await _unitOfWork.Context.Select<TResponse>("sp_get_employee", _parameters);
            return response.FirstOrDefault();
        }


        public async Task<IEnumerable<TResponse>> SearchByCriteria<TResponse>
             (System.Func<TResponse, bool> filters = null, int pageNumber = 0)
         where TResponse : IQueryResponseBase
        {
            _parameters.Clear();
            _parameters.Add("PageNumber", pageNumber);

            await _unitOfWork.Context.OpenContextAsync();
            var responses = await _unitOfWork.Context.Select<TResponse>("sp_get_allemployees", _parameters);

            if(filters is not null)
                responses = responses.Where(filters);
            return responses.ToList();
        }


        public async Task<int> CountAllEmployees()
        {
            Task<int> response;
            var tasks = Task.WhenAll(
                _unitOfWork.Context.OpenContextAsync(),
                response = _unitOfWork.Context.Count("sp_count_allemployees")
                );
            await tasks;
            return response.Result;
        }


    }
}
