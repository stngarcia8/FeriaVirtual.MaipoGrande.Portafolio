using System;
using System.Collections.Generic;
using FeriaVirtual.Domain.Models.Users.Rules;
using FeriaVirtual.Domain.SeedWork;
using FeriaVirtual.Domain.SeedWork.Validations;

namespace FeriaVirtual.Domain.Models.Users
{
    public class User
        : EntityBase, IAggregateRoot
    {
        public Guid UserId { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Dni { get; protected set; }
        public int ProfileId { get; protected set; }
        public Credential GetCredential { get; protected set; }


        internal User() { }

        public User
            (string firstName, string lastName, string dni, int profileId)
        {
            InitializeVars(GuidGenerator.NewSequentialGuid(),
                firstName, lastName, dni, profileId);
            GetCredential = null;
            var userRule = new CreateUserRules();
            CheckRule(BusinessRulesValidator<User>.BuildValidator(userRule, this));
        }

        public User
            (Guid id, string firstName, string lastName, string dni, int profileId)
        {
            InitializeVars(id, firstName, lastName,
                dni, profileId);
            var userRule = new UpdateUserRules();
            CheckRule(BusinessRulesValidator<User>.BuildValidator(userRule, this));
        }

        private void InitializeVars(
            Guid id, string firstName, string lastName,
            string dni, int profileId)
        {
            UserId = id;
            FirstName = firstName;
            LastName = lastName;
            Dni = dni;
            ProfileId = profileId;
        }

        public void CreateCredentials(
            string username, string password, string email) =>
            GetCredential = new Credential(username, password, email);

        public void GenerateCredentials(
            Guid id, string username, string password, string email, int isActive) =>
            GetCredential = new Credential(id, username, password, email, isActive);

        public void ChangeFirstName(string firstName) =>
            FirstName= firstName;

        public void ChangeLastName(string lastName) =>
            LastName = lastName;

        public void ChangeDni(string dni) =>
            Dni = dni;

        public void ChangeProfile(int profileId) =>
            ProfileId= profileId;

        public void EnableUser() =>
            GetCredential.EnableCredential();

        public void DisableUser() => 
            GetCredential.DisableCredential();

        public override Dictionary<string, object> GetPrimitives()
        {
            if (GetCredential == null) return null;
            return new Dictionary<string, object> {
                { "UserId", UserId},
                {"CredentialId", GetCredential.CredentialId },
                {"ProfileId", ProfileId },
                {"FirstName", FirstName },
                {"LastName", LastName },
                {"Dni", Dni }
            };
        }



        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }


    }
}
