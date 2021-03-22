using System;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.SeedWork.Events
{
    public abstract class DomainEventBase
    {
        public DomainEventId EventId { get; protected set; }
        public Dictionary<string, object> Body { get; protected set; }
        public DateTime OcurredOn { get; protected set; }


        public DomainEventBase()
        {
            EventId = new DomainEventId();
            Body = new Dictionary<string, object>();
            OcurredOn = DateTime.UtcNow;
        }


        public DomainEventBase
            (DomainEventId eventId, Dictionary<string, object> body)
        {
            EventId = eventId;
            Body = body;
            OcurredOn = DateTime.UtcNow;
        }

        public abstract string EventName();

        public override string ToString() =>
            EventName();


    }
}
