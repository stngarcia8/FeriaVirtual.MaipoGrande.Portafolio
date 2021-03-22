using FeriaVirtual.Domain.SeedWork.Events;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.Models.Users.Events
{
    class UserWasCreated
        : DomainEventBase
    {
        public UserWasCreated()
            : base() { }


        public UserWasCreated
            (DomainEventId eventId, Dictionary<string, object> body)
            : base(eventId, body) { }


        public override string EventName() =>
            "User.UserWasCreated";


    }
}
