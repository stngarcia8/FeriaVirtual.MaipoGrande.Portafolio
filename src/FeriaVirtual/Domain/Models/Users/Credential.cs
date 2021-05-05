using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.Models.Users.Rules;
using FeriaVirtual.Domain.SeedWork;
using FeriaVirtual.Domain.SeedWork.Helpers.Security;
using System;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.Models.Users
{
    public class Credential
        : EntityBase
    {
        private Guid _userId;
        private readonly bool _isUpdate;

        public Guid CredentialId { get; protected set; }
        public string Username { get; protected set; }
        public string Password { get; protected set; }
        public string Email { get; protected set; }
        public int IsActive { get; protected set; }
        public string EncryptedPassword { get; protected set; }


        public Credential(Guid userid)
        {
            _userId = userid;
            InitializeVars(GuidGenerator.NewSequentialGuid(),
                string.Empty, string.Empty, string.Empty, 0);
        }

        public Credential
            (Guid userid, string username, string password,
            string email, IUserUniquenessChecker uniquenessChecker)
        {
            _isUpdate = false;
            CheckRule(new UsernameMustBeUniqueRule(uniquenessChecker, username));
            CheckRule(new UserEmailMustBeUniqueRule(uniquenessChecker, email));

            _userId = userid;
            InitializeVars(GuidGenerator.NewSequentialGuid(),
                username, password, email, 1);
        }

        public Credential
            (Guid userid, Guid id, string username, string email,
            int isActive, IUserUniquenessChecker uniquenessChecker)
        {
            _isUpdate = true;
            CheckRule(new UsernameMustBeUniqueRule(uniquenessChecker, username));
            CheckRule(new UserEmailMustBeUniqueRule(uniquenessChecker, email));

            _userId = userid;
            InitializeVars(id, username, string.Empty, email, isActive);
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
            EncryptedPassword = EncryptPassword();
        }


        private string EncryptPassword()
        {
            if(string.IsNullOrWhiteSpace(Password))
                return string.Empty;

            IEncriptor encryptor = EncriptSha1.CreateEncriptor(Password);
            return encryptor.GetEncriptedPassword();
        }


        public void EnableCredential()
            => IsActive = 1;


        public void DisableCredential()
            => IsActive = 0;


        public void ChangePassword(string password)
        {
            Password = password;
            EncryptedPassword = EncryptPassword();
        }



        public override Dictionary<string, object> GetPrimitives()
        {
            var primitives =  new Dictionary<string, object> {
                {"CredentialId", CredentialId.ToString() },
                {"UserId", _userId.ToString() },
                {"Username", Username },
                { "Password", EncryptedPassword},
                { "Email", Email },
                {"IsActive", IsActive }
            };
            if(_isUpdate) {
                primitives.Remove("CredentialId");
                primitives.Remove("Password");
                primitives.Remove("IsActive");
            }

            return primitives;
        }


    }
}
