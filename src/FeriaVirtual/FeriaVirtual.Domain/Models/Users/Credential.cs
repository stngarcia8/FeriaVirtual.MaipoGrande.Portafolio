using System;
using System.Collections.Generic;
using FeriaVirtual.Domain.Models.Users.Rules;
using FeriaVirtual.Domain.SeedWork;
using FeriaVirtual.Domain.SeedWork.Helpers.Security;
using FeriaVirtual.Domain.SeedWork.Validations;

namespace FeriaVirtual.Domain.Models.Users
{
    public class Credential
        : EntityBase
    {
        private readonly string _oldPassword;

        public Guid CredentialId { get; protected set; }
        public string Username { get; protected set; }
        public string Password { get; protected set; }
        public string Email { get; protected set; }
        public int IsActive { get; protected set; }
        public string EncryptedPassword { get; protected set; }


        internal Credential() { }

        public Credential
            (string username, string password, string email)
        {
            _oldPassword = password;
            InitializeVars(GuidGenerator.NewSequentialGuid(),
                username, password, email, 1);
            var credentialRule = new CreateCredentialRules();
            CheckRule(BusinessRulesValidator<Credential>.BuildValidator(credentialRule, this));
        }

        public Credential
            (Guid id, string username, string password,
            string email, int isActive)
        {
            _oldPassword = password;
            InitializeVars(id, username, password,
                email, isActive);
            var credentialRule = new UpdateCredentialRules();
            CheckRule(BusinessRulesValidator<Credential>.BuildValidator(credentialRule, this));
        }

        private void InitializeVars
            (Guid id, string username, string password,
            string email, int isActive)
        {
            CredentialId = id;
            Username = username;
            Password = password;
            Email = email;
            IsActive = isActive;
            EncryptedPassword = !string.IsNullOrWhiteSpace(_oldPassword) ? EncryptPassword() : password;
        }

        private string EncryptPassword()
        {
            if (string.IsNullOrWhiteSpace(_oldPassword)) {
                return string.Empty;
            }
            IEncriptor encryptor = EncriptSha1.CreateEncriptor(_oldPassword);
            return encryptor.GetEncriptedPassword();
        }

        public void EnableCredential() =>
            IsActive = 1;

        public void DisableCredential() =>
            IsActive = 0;

        public override Dictionary<string, object> GetPrimitives()
        {
            return new Dictionary<string, object> {
                {"CredentialId", CredentialId.ToString() },
                {"Username", Username },
                { "Password", EncryptedPassword},
                { "Email", Email },
                {"IsActive", IsActive }
            };
        }









    }
}
