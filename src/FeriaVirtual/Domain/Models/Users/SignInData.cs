using FeriaVirtual.Domain.Models.Users.Rules;
using FeriaVirtual.Domain.SeedWork.Helpers.Security;
using FeriaVirtual.Domain.SeedWork.Validations;
using FeriaVirtual.Domain.SeedWork.ValueObjects;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.Models.Users
{
    public class SignInData
        : ValueObject
    {
        public string Username;
        public string Password;

        public SignInData(string username, string password)
        {
            Username = username;
            Password = password;
            ValidateVars();
            EncriptPassword();
        }

        private void ValidateVars()
        {
            var signinRule = new SignInRules();
            CheckRule(BusinessRulesValidator<SignInData>.BuildValidator(signinRule, this));
        }

        private void EncriptPassword()
        {
            IEncriptor encryptor = EncriptSha1.CreateEncriptor(Password);
            Password = encryptor.GetEncriptedPassword();
        }

        protected  override IEnumerable<object> GetAtomicValues()
        {
            yield return Username;
            yield return Password;
        }

        public Dictionary<string, object> GetPrimitives() =>
            new()
            {
                { "Username", Username },
                { "Password", Password }
            };


    }
}
