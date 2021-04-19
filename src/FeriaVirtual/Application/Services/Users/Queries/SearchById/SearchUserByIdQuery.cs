using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Services.Users.Queries.SearchById
{
    public class SearchUserByIdQuery
        : Query
    {
        public System.Guid Id { get; protected set; }


        public SearchUserByIdQuery(string id) =>
            Id = new System.Guid(id);


    }
}
