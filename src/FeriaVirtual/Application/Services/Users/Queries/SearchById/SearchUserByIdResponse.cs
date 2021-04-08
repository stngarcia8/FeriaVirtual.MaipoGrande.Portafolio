using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Services.Users.Queries.SearchById
{
    public class SearchUserByIdResponse
        : IQueryResponseBase
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }

        public int ProfileId { get; set; }
        public string ProfileName { get; set; }

        public string CredentialId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int IsActive { get; set; }
        public string UserStatus { get; set; }


        public SearchUserByIdResponse() { }


    }
}
