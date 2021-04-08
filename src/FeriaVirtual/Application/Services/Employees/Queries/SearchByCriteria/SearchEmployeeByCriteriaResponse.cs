using FeriaVirtual.Domain.SeedWork.Query;

namespace FeriaVirtual.Application.Services.Employees.Queries.SearchByCriteria
{
    public class SearchEmployeeByCriteriaResponse
        : IQueryResponseBase
    {
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Dni { get; set; }
        public string ProfileName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string UserStatus { get; set; }


        public SearchEmployeeByCriteriaResponse() { }


    }
}
