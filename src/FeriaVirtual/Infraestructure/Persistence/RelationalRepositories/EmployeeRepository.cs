using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.FiltersByCriteria;
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
            IEnumerable<TResponse> response = await _unitOfWork.Context.SelectAsync<TResponse>("sp_get_employee", _parameters);
            return response.FirstOrDefault();
        }


        public async Task<IEnumerable<TResponse>> SearchByCriteria<TResponse>
            (Criteria criteria, int limit = 0, int offset = 0)
            where TResponse : IQueryResponseBase
        {
            _parameters.Clear();
            _parameters.Add("FieldName", criteria.FieldName);
            _parameters.Add("FieldValue", criteria.FieldValue);
            _parameters.Add("Limit", limit);
            _parameters.Add("Offset", offset);

            await _unitOfWork.Context.OpenContextAsync();
            var responses = await _unitOfWork.Context.SelectAsync<TResponse>("sp_get_employees", _parameters);
            return responses.ToList();
        }


        public async Task<int> CountEmployeesAsync(Criteria criteria)
        {
            _parameters.Clear();
            _parameters.Add("FieldName", criteria.FieldName);
            _parameters.Add("FieldValue", criteria.FieldValue);

            Task<int> response;
            var tasks = Task.WhenAll(
                _unitOfWork.Context.OpenContextAsync(),
                response = _unitOfWork.Context.CountAsync("sp_count_employees", _parameters)
                );
            await tasks;
            return response.Result;
        }


    }
}
