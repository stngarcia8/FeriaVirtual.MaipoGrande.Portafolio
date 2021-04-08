using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Services.Signin.Queries
{
    public class SigninResponse
        : IQueryResponseBase
    {
        public string FullName { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public int ProfileId { get; set; }
        public int IsActive { get; set; }


        public SigninResponse() { }


    }
}
