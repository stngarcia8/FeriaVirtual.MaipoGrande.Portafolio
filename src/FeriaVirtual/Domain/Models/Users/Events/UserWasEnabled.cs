using FeriaVirtual.Domain.SeedWork.Events;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.Models.Users.Events
{
    class UserWasEnabled
        : DomainEventBase
    {
        public UserWasEnabled()
            : base() { }


        public UserWasEnabled
            (DomainEventId eventId, Dictionary<string, object> body)
            : base(eventId, body) { }


        public override string EventName() =>
            "User.UserWasEnabled";


    }
}
