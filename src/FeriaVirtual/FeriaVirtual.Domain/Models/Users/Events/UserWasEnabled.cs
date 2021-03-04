using System;
using FeriaVirtual.Domain.SeedWork.Events;

namespace FeriaVirtual.Domain.Models.Users.Events
{
    class UserWasEnabled
        : DomainEventBase
    {
        public UserWasEnabled()
            : base() { }

        public UserWasEnabled(Guid eventId, object content)
            : base(eventId, content) { }

        public override string EventName() =>
            "User.UserWasEnabled";



    }
}
