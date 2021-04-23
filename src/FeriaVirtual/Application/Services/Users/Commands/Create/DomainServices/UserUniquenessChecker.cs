using FeriaVirtual.Application.Services.Users.Queries.UniquenessChecker;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Query;
using System.Threading.Tasks;

namespace FeriaVirtual.Application.Services.Users.Commands.Create.DomainServices
{
    public class UserUniquenessChecker
        : IUserUniquenessChecker
    {
        private readonly IQueryBus _queryBus;

        public bool UsernameIsUnique { get; protected set; }
        public bool DniIsUnique { get; protected set; }
        public bool EmailIsUnique { get; protected set; }


        public UserUniquenessChecker(IQueryBus queryBus)
            => _queryBus = queryBus;


        public async Task Check
            (string username, string dni, string email)
        {
            UserUniquenessCheckerQuery query = new() {
                Username = username,
                Dni = dni,
                Email = email
            };
            var result =  await _queryBus.Ask<UserUniquenessCheckerResponse>(query);
            UsernameIsUnique = result.UsernameRegistered.Equals(0);
            DniIsUnique = result.DniRegistered.Equals(0);
            EmailIsUnique = result.EmailRegistered.Equals(0);
        }


    }
}