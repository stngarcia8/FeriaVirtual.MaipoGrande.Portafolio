using FeriaVirtual.Domain.SeedWork.Events;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.Models.Users.Events
{
    class UserWasUpdated
        : DomainEventBase
    {
        public UserWasUpdated()
            : base() { }


        public UserWasUpdated
            (DomainEventId eventId, Dictionary<string, object> body)
            : base(eventId, body) { }


        public override string EventName() =>
            "User.UserWasUpdated";

        public override Dictionary<string, string> ToPrimitives()
        {
            Dictionary<string, string> values = new();
            foreach (var item in Body)
                values.Add(item.Key, item.Value.ToString());
            return values;
        }


        public override UserWasUpdated FromPrimitives
            (DomainEventId eventId, Dictionary<string, object> body) =>
            new(eventId, body);



    }
}
