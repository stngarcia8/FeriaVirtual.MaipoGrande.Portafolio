using FeriaVirtual.Domain.SeedWork.Events;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.Models.Users.Events
{
    class UserPasswordWasChanged
        : DomainEventBase
    {
        public UserPasswordWasChanged()
            : base() { }


        public UserPasswordWasChanged
            (DomainEventId eventId, Dictionary<string, object> body)
            : base(eventId, body) { }


        public override string EventName()
            => "User.ChangePassword";


        public override DomainEventBase FromPrimitives
            (DomainEventId eventId, Dictionary<string, object> body)
            => new UserPasswordWasChanged(eventId, body);

    }
}
