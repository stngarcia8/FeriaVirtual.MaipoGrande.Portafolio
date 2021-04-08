using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Services.Employees.Queries.Counter
{
    public class EmployeeCounterQueryHandler
        : IQueryHandler<EmployeeCounterQuery, EmployeeCounterResponse>
    {
        private readonly IEmployeeRepository _repository;


        public EmployeeCounterQueryHandler(IEmployeeRepository repository) =>
            _repository = repository;


        public EmployeeCounterResponse Handle(EmployeeCounterQuery query) =>
            new() {
                Total = _repository.CountAllEmployees()
            };


    }
}
