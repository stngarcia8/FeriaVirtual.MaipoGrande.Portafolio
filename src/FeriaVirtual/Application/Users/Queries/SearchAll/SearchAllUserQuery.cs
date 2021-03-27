using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Users.Queries.SearchAll
{
    public class SearchAllUserQuery
        : Query
    {
        public int PageNumber { get; protected set; }


        public SearchAllUserQuery(int pageNumber = 0) =>
            PageNumber = pageNumber;


    }
}
