using System;
using FeriaVirtual.Domain.SeedWork;
using System.Collections.Generic;
using System.Text;
using FeriaVirtual.Domain.Models.Users.Rules;
using FeriaVirtual.Domain.SeedWork.Validations;
using FeriaVirtual.Domain.SeedWork.Helpers.Security;

namespace FeriaVirtual.Domain.Models.Users
{
    public class SignInData
        :ValueObject
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

        public override Dictionary<string, object> GetPrimitives() =>
            new Dictionary<string, object>{
                { "Username", Username},
                { "Password", Password}
            };


    }
}
