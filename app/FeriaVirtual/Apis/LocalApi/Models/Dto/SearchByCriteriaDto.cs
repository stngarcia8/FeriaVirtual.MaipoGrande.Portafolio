namespace FeriaVirtual.Api.Local.Models.Dto
{
    public class SearchByCriteriaDto
    {
        public string SearchType { get; }
        public object SearchValue { get; }
        public int PageNumber { get; }


        public SearchByCriteriaDto
            (string searchType, object searchValue, int pagenumber)
        {
            SearchType = searchType;
            SearchValue = searchValue;
            PageNumber = pagenumber;
        }


    }
}
