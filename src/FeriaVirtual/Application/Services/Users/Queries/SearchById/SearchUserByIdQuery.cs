using FeriaVirtual.Domain.SeedWork.Query;
using System;

namespace FeriaVirtual.Application.Services.Users.Queries.SearchById
{
    public class SearchUserByIdQuery
        : Query
    {
        public Guid Id { get; protected set; }


        public SearchUserByIdQuery(string id) =>
            Id = new Guid(id);


    }
}
