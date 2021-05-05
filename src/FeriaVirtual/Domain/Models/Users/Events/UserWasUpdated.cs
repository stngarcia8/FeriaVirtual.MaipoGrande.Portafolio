using FeriaVirtual.Domain.SeedWork.Events;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.Models.Users.Events
{
    class UserWasUpdated
        : DomainEventBase
    {
        public UserWasUpdated()
            : base() { }


        public UserWasUpdated
            (DomainEventId eventId, Dictionary<string, object> body)
            : base(eventId, body) { }


        public override string EventName() =>
            "User.Updated";

        public override DomainEventBase FromPrimitives
            (DomainEventId eventId, Dictionary<string, object> body) =>
            new UserWasUpdated(eventId, body);



    }
}
