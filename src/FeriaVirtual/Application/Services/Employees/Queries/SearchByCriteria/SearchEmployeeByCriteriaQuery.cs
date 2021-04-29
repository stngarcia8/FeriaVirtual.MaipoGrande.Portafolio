using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Services.Employees.Queries.SearchByCriteria
{
    public class SearchEmployeeByCriteriaQuery
        : Query
    {
        public string FilterType { get; set; }
        public string FilterValue { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }


        public SearchEmployeeByCriteriaQuery() { }


    }
}
