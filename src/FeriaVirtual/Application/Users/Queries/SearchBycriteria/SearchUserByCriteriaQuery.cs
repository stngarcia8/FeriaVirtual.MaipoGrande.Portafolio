using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Users.Queries.SearchBycriteria
{
    public class SearchUserByCriteriaQuery
        : Query
    {
        public string SearchType { get; }
        public object SearchValue { get; }
        public int PageNumber { get; }


        public SearchUserByCriteriaQuery
            (string searchType, object searchValue, int pagenumber=0)
        {
            SearchType = searchType;
            SearchValue = searchValue;
            PageNumber = pagenumber;
        }


    }
}
