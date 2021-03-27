using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Users.Queries.SearchAll
{
    public class SearchAllUserResponse
        :IQueryResponseBase
    {
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Dni { get; set; }
        public string ProfileName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string UserStatus { get; set; }


        public SearchAllUserResponse() { }


    }
}
