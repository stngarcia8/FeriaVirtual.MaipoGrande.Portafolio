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
            "UserWasCreated";


        public override Dictionary<string, string> ToPrimitives()
        {
            Dictionary<string, string> values = new();
            foreach (var item in Body)
                values.Add(item.Key, item.Value.ToString());
            return values;
        }

        public override DomainEventBase FromPrimitives
            (DomainEventId eventId, Dictionary<string, object> body) => 
            new UserWasCreated(eventId, body);


    }
}
