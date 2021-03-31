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


        public TResponse SearchById<TResponse>(Guid userId)
            where TResponse : IQueryResponseBase
        {
            _parameters.Clear();
            _parameters.Add("UserId", userId.ToString());
            return _unitOfWork.Context.Select<TResponse>("sp_get_employee", _parameters).FirstOrDefault();
        }


        public IEnumerable<TResponse> SearchByCriteria<TResponse>
             (Func<TResponse, bool> filters = null, int pageNumber = 0)
         where TResponse : IQueryResponseBase
        {
            _parameters.Clear();
            _parameters.Add("PageNumber", pageNumber);
            IEnumerable<TResponse> results = _unitOfWork.Context.Select<TResponse>("sp_get_allemployees", _parameters);
            if (filters != null)
                results = results.Where(filters);
            return results.ToList();
        }

        public int CountAllEmployees() =>
            _unitOfWork.Context.Count("sp_count_allemployees");


    }
}
