using FeriaVirtual.Domain.SeedWork.Query;
using System;

namespace FeriaVirtual.Application.Services.Employees.Queries.SearchById
{
    public class SearchEmployeeByIdQuery
        : Query
    {
        public Guid Id { get; protected set; }


        public SearchEmployeeByIdQuery(Guid id) =>
            Id = id;


    }
}
