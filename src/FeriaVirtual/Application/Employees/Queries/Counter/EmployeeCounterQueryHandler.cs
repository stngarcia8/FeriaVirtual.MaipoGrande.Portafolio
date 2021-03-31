using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Employees.Queries.Counter
{
    public class EmployeeCounterQueryHandler
        : IQueryHandler<EmployeeCounterQuery, EmployeeCounterResponse>
    {
        private readonly IEmployeeRepository _repository;


        public EmployeeCounterQueryHandler(IEmployeeRepository repository) =>
            _repository = repository;


        public EmployeeCounterResponse Handle(EmployeeCounterQuery query)
        {
            var counter = _repository.CountAllEmployees();
            return new EmployeeCounterResponse {
                Total = counter
            };

        }


    }
}
