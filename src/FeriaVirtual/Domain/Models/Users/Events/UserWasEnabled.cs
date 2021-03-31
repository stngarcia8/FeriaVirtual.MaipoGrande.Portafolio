using FeriaVirtual.Domain.SeedWork.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Domain.Models.Users.Events
{
    public class UserWasEnabled
        : DomainEventBase
    {
        public UserWasEnabled()
            : base() { }


        public UserWasEnabled
            (DomainEventId eventId, Dictionary<string, object> body)
            : base(eventId, body) { }


        public override string EventName() =>
            "User.Enabled";


        public override DomainEventBase FromPrimitives
            (DomainEventId eventId, Dictionary<string, object> body) => 
            new UserWasEnabled(eventId, body);


    }
}
