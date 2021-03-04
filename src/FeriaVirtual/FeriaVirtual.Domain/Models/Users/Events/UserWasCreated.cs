using System;
using FeriaVirtual.Domain.SeedWork.Events;

namespace FeriaVirtual.Domain.Models.Users.Events
{
    class UserWasCreated
        : DomainEventBase
    {
        public UserWasCreated()
            : base() { }

        public UserWasCreated(Guid eventId, object content)
            : base(eventId, content) { }

        public override string EventName() => 
            "User.UserWasCreated";

    }
}
