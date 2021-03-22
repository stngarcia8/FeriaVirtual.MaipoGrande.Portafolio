using FeriaVirtual.Domain.SeedWork.Events;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.Models.Users.Events
{
    class UserWasDisabled
        : DomainEventBase
    {
        public UserWasDisabled()
            : base() { }


        public UserWasDisabled
            (DomainEventId eventId, Dictionary<string, object> body)
            : base(eventId, body) { }


        public override string EventName() =>
            "User.UserWasDisabled";


    }
}
