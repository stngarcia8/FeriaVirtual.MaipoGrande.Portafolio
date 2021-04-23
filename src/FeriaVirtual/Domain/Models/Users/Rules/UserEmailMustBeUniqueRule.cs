using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Validations;

namespace FeriaVirtual.Domain.Models.Users.Rules
{
    public class UserEmailMustBeUniqueRule
        : IBusinessRule
    {
        private readonly IUserUniquenessChecker _uniquenessChecker;
        private readonly string _email;


        public UserEmailMustBeUniqueRule
            (IUserUniquenessChecker uniquenessChecker, string email)
        {
            _uniquenessChecker = uniquenessChecker;
            _email = email;
        }


        public bool IsFailed()
            => !_uniquenessChecker.EmailIsUnique;

        public string Message
            => $"Email de usuario ({_email}) fue registrado por otra persona.";


    }
}
