using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Users.Queries.Counter
{
    public class UserCounterResponse
        : IQueryResponseBase
    {
        public int Total { get; set; }


        public UserCounterResponse() { }


    }
}
