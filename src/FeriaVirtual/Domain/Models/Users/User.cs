using FeriaVirtual.Domain.Models.Users.Events;
using FeriaVirtual.Domain.Models.Users.Rules;
using FeriaVirtual.Domain.SeedWork;
using FeriaVirtual.Domain.SeedWork.Events;
using FeriaVirtual.Domain.SeedWork.Validations;
using System;
using System.Collections.Generic;

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
            var eventId = new DomainEventId(UserId);
            CheckRule(BusinessRulesValidator<User>.BuildValidator(userRule, this));
            this.Record(new UserWasCreated(eventId, this.GetPrimitives()));
        }


        public User
            (Guid id, string firstName, string lastName, string dni, int profileId)
        {
            InitializeVars(id, firstName, lastName,
                dni, profileId);
            var userRule = new UpdateUserRules();
            var eventId = new DomainEventId(GuidGenerator.NewSequentialGuid());
            CheckRule(BusinessRulesValidator<User>.BuildValidator(userRule, this));
            this.Record(new UserWasUpdated(eventId, this.GetPrimitives()));
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


        public void CreateCredentials
            (string username, string password, string email) =>
            GetCredential = new Credential(username, password, email);


        public void GenerateCredentials
            (Guid id, string username, string password, string email, int isActive) =>
            GetCredential = new Credential(id, username, password, email, isActive);


        public void EnableUser()
        {
            GetCredential.EnableCredential();
            var eventId = new DomainEventId(UserId);
            this.Record(new UserWasEnabled(eventId, this.GetPrimitives()));
        }


        public void DisableUser()
        {
            GetCredential.DisableCredential();
            var eventId = new DomainEventId(UserId);
            this.Record(new UserWasDisabled(eventId, this.GetPrimitives()));
        }


        public override Dictionary<string, object> GetPrimitives() =>
            GetCredential == null ? null
                : new Dictionary<string, object> {
                { "UserId", UserId.ToString()},
                {"CredentialId", GetCredential.CredentialId.ToString() },
                {"ProfileId", ProfileId },
                {"FirstName", FirstName },
                {"LastName", LastName },
                {"Dni", Dni }
            };


        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }


    }
}
