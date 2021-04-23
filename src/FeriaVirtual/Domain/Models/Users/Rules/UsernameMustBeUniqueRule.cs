using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Validations;

namespace FeriaVirtual.Domain.Models.Users.Rules
{
    public class UsernameMustBeUniqueRule
        : IBusinessRule
    {
        private readonly IUserUniquenessChecker _uniquenessChecker;
        private readonly string _username;


        public UsernameMustBeUniqueRule
            (IUserUniquenessChecker uniquenessChecker, string username)
        {
            _uniquenessChecker = uniquenessChecker;
            _username = username;
        }


        public bool IsFailed()
            => !_uniquenessChecker.UsernameIsUnique;

        public string Message
            => $"Username ({_username}) esta siendo utilizado por otra persona.";


    }
}
