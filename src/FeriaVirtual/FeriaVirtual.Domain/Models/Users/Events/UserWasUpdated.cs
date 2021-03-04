using System;
using FeriaVirtual.Domain.SeedWork.Events;

namespace FeriaVirtual.Domain.Models.Users.Events
{
    class UserWasUpdated
        : DomainEventBase
    {
        public UserWasUpdated()
            : base() { }

        public UserWasUpdated(Guid eventId, object content)
            : base(eventId, content) { }

        public override string EventName() => 
            "User.UserWasUpdated";



    }
}
