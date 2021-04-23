using FeriaVirtual.Domain.SeedWork.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Users.Queries.UniquenessChecker
{
    public class UserUniquenessCheckerResponse
        :IQueryResponseBase
    {
        public int UsernameRegistered { get; set; }
        public int DniRegistered { get; set; }
        public int EmailRegistered { get; set; }


        public UserUniquenessCheckerResponse() { }


    }
}
