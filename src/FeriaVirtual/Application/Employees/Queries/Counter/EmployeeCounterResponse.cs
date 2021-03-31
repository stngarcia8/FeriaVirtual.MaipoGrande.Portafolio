using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Employees.Queries.Counter
{
    public class EmployeeCounterResponse
        : IQueryResponseBase
    {
        public int Total { get; set; }


        public EmployeeCounterResponse() { }


    }
}
