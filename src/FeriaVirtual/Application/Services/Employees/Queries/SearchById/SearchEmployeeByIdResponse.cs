using FeriaVirtual.Domain.SeedWork.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Employees.Queries.SearchById
{
    public class SearchEmployeeByIdResponse
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


        public SearchEmployeeByIdResponse() { }


    }
}
