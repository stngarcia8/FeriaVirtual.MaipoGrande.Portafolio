using FeriaVirtual.Domain.SeedWork.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Employees.Queries.Counter
{
    public class EmployeeCounterResponse
        :IQueryResponseBase
    {
        public int Total { get; set; }


        public EmployeeCounterResponse() { }


    }
}
