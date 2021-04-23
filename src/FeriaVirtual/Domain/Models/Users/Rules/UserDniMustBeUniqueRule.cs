using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.SeedWork.Validations;

namespace FeriaVirtual.Domain.Models.Users.Rules
{
    public class UserDniMustBeUniqueRule
        : IBusinessRule
    {
        private readonly IUserUniquenessChecker _uniquenessChecker;
        private readonly string _dni;


        public UserDniMustBeUniqueRule
            (IUserUniquenessChecker uniquenessChecker, string dni)
        {
            _uniquenessChecker = uniquenessChecker;
            _dni = dni;
        }


        public bool IsFailed()
            => !_uniquenessChecker.DniIsUnique;

        public string Message
            => $"Dni/Rut de usuario ({_dni}) está enlazado a otra persona.";


    }
}
