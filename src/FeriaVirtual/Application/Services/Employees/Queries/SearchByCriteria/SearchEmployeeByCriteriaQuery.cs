using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Services.Employees.Queries.SearchByCriteria
{
    public class SearchEmployeeByCriteriaQuery
        : Query
    {
        public string SearchType { get; }
        public object SearchValue { get; }
        public int PageNumber { get; }


        public SearchEmployeeByCriteriaQuery
            (string searchType, object searchValue, int pagenumber = 0)
        {
            SearchType = searchType;
            SearchValue = searchValue;
            PageNumber = pagenumber;
        }


    }
}
