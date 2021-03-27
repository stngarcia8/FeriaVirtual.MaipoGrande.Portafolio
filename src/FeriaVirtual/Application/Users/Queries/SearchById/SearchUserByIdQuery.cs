using FeriaVirtual.Domain.SeedWork.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Users.Queries.SearchById
{
    public class SearchUserByIdQuery
        :Query
    {
        public Guid UserId { get; protected set; }


        public SearchUserByIdQuery(string userId) =>
            UserId = new Guid(userId);


    }
}
