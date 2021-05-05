using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Services.Employees.Queries.Counter
{
    public class EmployeeCounterResponse
        : IQueryResponseBase
    {
        public int Total { get; set; }


        public EmployeeCounterResponse() { }


    }
}
