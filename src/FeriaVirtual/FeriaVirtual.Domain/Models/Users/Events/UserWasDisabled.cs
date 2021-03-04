using System;
using FeriaVirtual.Domain.SeedWork.Events;

namespace FeriaVirtual.Domain.Models.Users.Events
{
    class UserWasDisabled
        : DomainEventBase
    {
        public UserWasDisabled()
            : base() { }

        public UserWasDisabled(Guid eventId, object content)
            : base(eventId, content) { }

        public override string EventName() => 
            "User.UserWasDisabled";



    }
}
