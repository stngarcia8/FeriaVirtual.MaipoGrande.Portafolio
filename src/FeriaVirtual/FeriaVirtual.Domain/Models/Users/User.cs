using System;
using System.Collections.Generic;
using FeriaVirtual.Domain.Models.Users.Credentials;
using FeriaVirtual.Domain.SeedWork;

namespace FeriaVirtual.Domain.Models.Users
{
    public class User
        : EntityBase
    {
        public Guid UserId { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Dni { get; protected set; }
        public int ProfileId { get; protected set; }
        public Credential GetCredential { get; protected set; }


        public User(string firstName, string lastName,
            string dni, int profileId)
        {
            InitializeVars(GuidGenerator.NewSequentialGuid(),
                firstName, lastName, dni, profileId);
            GetCredential = null;
        }

        public User(
            Guid id, string firstName, string lastName,
            string dni, int profileId)
        {
            InitializeVars(id, firstName, lastName,
                dni, profileId);
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

        public void EnableUser()
        {
            if (GetCredential == null) return;
            GetCredential.EnableCredential();
        }

        public void DisableUser()
        {
            if (GetCredential == null) return;
            GetCredential.DisableCredential();
        }

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
