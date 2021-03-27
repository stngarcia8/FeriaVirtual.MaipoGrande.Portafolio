using FeriaVirtual.Domain.SeedWork.Events;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.Models.Users.Events
{
    public class UserWasDisabled
        : DomainEventBase
    {
        public UserWasDisabled()
            : base() { }


        public UserWasDisabled
            (DomainEventId eventId, Dictionary<string, object> body)
            : base(eventId, body) { }


        public override string EventName() =>
            "UserWasDisabled";


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
