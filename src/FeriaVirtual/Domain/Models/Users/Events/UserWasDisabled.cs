using FeriaVirtual.Domain.SeedWork.Events;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.Models.Users.Events
{
    public class UserWasDisabled
        : DomainEventBase
    {
        public UserWasDisabled()
            : base() { }


        public UserWasDisabled
            (DomainEventId eventId, Dictionary<string, object> body)
            : base(eventId, body) { }


        public override string EventName()
            => "User.Disabled";


        public override DomainEventBase FromPrimitives
            (DomainEventId eventId, Dictionary<string, object> body)
            => new UserWasDisabled(eventId, body);


    }
}
