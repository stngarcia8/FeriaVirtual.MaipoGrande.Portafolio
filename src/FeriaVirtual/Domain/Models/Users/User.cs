using FeriaVirtual.Domain.Models.Users.Events;
using FeriaVirtual.Domain.Models.Users.Interfaces;
using FeriaVirtual.Domain.Models.Users.Rules;
using FeriaVirtual.Domain.SeedWork;
using FeriaVirtual.Domain.SeedWork.Events;
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


        public User(Guid id)
            => UserId = id;

        public User
            (string firstName, string lastName, string dni, int profileId,
            string username, string password, string email,
            IUserUniquenessChecker uniquenessChecker)
        {
            CheckRule(new UserDniMustBeUniqueRule(uniquenessChecker, dni));
            InitializeVars(GuidGenerator.NewSequentialGuid(), firstName, lastName, dni, profileId);
            CreateCredentials(username, password, email, uniquenessChecker);

            var eventId = new DomainEventId(UserId);
            Record(new UserWasCreated(eventId, this.GetPrimitives()));
        }


        public User
            (Guid userId, string firstName, string lastName, string dni, int profileId,
            Guid credentialId, string username, string email,
            int isActive, IUserUniquenessChecker uniquenessChecker)
        {
            CheckRule(new UserDniMustBeUniqueRule(uniquenessChecker, dni));
            InitializeVars(userId, firstName, lastName, dni, profileId);
            GenerateCredentials(credentialId, username, email, isActive, uniquenessChecker);

            var eventId = new DomainEventId(GuidGenerator.NewSequentialGuid());
            Record(new UserWasUpdated(eventId, this.GetPrimitives()));
        }


        private void InitializeVars(
            Guid userId, string firstName, string lastName,
            string dni, int profileId)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Dni = dni;
            ProfileId = profileId;
        }


        private void CreateCredentials
            (string username, string password,
            string email, IUserUniquenessChecker uniquenessChecker)
            => GetCredential = new Credential(UserId, username, password, email, uniquenessChecker);


        private void GenerateCredentials
            (Guid credentialId, string username, string email, 
            int isActive, IUserUniquenessChecker uniquenessChecker)
            => GetCredential = new Credential(UserId, credentialId, username, email, isActive, uniquenessChecker);


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


        public override Dictionary<string, object> GetPrimitives()
            => new() {
                { "UserId", UserId.ToString() },
                { "ProfileId", ProfileId },
                { "FirstName", FirstName },
                { "LastName", LastName },
                { "Dni", Dni }
            };

        public override string ToString()
            => $"{FirstName} {LastName}";


    }
}
