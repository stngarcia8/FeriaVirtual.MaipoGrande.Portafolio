using System;
using Newtonsoft.Json;

namespace FeriaVirtual.Domain.SeedWork.Events
{
    public abstract class DomainEventBase
    {
        public Guid EventId { get; protected set; }
        public Object Body { get; protected set; }
        public DateTime OcurredOn { get; protected set; }


        public DomainEventBase()
        {
            EventId = GuidGenerator.NewSequentialGuid();
            Body = null;
            OcurredOn = DateTime.Now.Date;
        }

        public DomainEventBase
            (Guid eventId, object body)
        {
            EventId = eventId;
            Body = body;
            OcurredOn = DateTime.Now.Date;
        }

        public abstract string EventName();

        public string Serialize() =>
            JsonConvert.SerializeObject(Body);

        public override string ToString() =>
            EventName();


    }
}
