using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Services.Users.Queries.UniquenessChecker
{
    public class UserUniquenessCheckerResponse
        : IQueryResponseBase
    {
        public int UsernameRegistered { get; set; }
        public int DniRegistered { get; set; }
        public int EmailRegistered { get; set; }


        public UserUniquenessCheckerResponse() { }


    }
}
