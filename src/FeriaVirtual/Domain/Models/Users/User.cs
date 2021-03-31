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


        public User(Guid id) =>
            UserId = id;


        public User
            (string firstName, string lastName, string dni, int profileId,
            string username, string password, string email)
        {
            InitializeVars(GuidGenerator.NewSequentialGuid(), firstName, lastName, dni, profileId);
            CreateCredentials(username, password, email);
            var userRule = new CreateUserRules();
            var eventId = new DomainEventId(UserId);
            CheckRule(BusinessRulesValidator<User>.BuildValidator(userRule, this));
            this.Record(new UserWasCreated(eventId, this.GetPrimitives()));
        }


        public User
            (Guid id, string firstName, string lastName, string dni, int profileId,
            Guid credentialId, string username, string password, string email, int isActive)
        {
            InitializeVars(id, firstName, lastName, dni, profileId);
            GenerateCredentials(credentialId, username, password, email, isActive);
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


        private void CreateCredentials
            (string username, string password, string email) =>
            GetCredential = new Credential(username, password, email);


        private void GenerateCredentials
            (Guid id, string username, string password, string email, int isActive) =>
            GetCredential = new Credential(id, username, password, email, isActive);


        public void EnableUser()
        {
            Dictionary<string, object> values = new() {
                { "userId", UserId.ToString() },
                { "type", "Enable user" },
                { "value", 1 }
            };
            var eventId = new DomainEventId(UserId);
            this.Record(new UserWasEnabled(eventId, values));
        }


        public void DisableUser()
        {
            Dictionary<string, object> values = new() {
                { "userId", UserId.ToString() },
                { "type", "Disable user" },
                { "value", 0 }
            };
            var eventId = new DomainEventId(UserId);
            this.Record(new UserWasDisabled(eventId, values));
        }


        public override Dictionary<string, object> GetPrimitives() =>
            new() {
                { "UserId", UserId.ToString() },
                { "CredentialId", GetCredential is null ? string.Empty : GetCredential.CredentialId.ToString() },
                { "ProfileId", ProfileId },
                { "FirstName", FirstName },
                { "LastName", LastName },
                { "Dni", Dni }
            };


        public override string ToString() =>
            $"{FirstName} {LastName}";


    }
}
