﻿using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Services.Employees.Queries.Counter
{
    public class EmployeeCounterQuery
        : Query
    {
        public string FilterType { get; set; }
        public string FilterValue { get; set; }


        public EmployeeCounterQuery() { }


    }
}
