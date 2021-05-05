using System.Collections.Generic;

namespace FeriaVirtual.Domain.SeedWork.Events
{
    public class DomainEventPrimitive
    {
        public string EventId { get; set; }
        public string Name { get; set; }
        public Dictionary<string, string> Body { get; set; }
        public string OcurredOn { get; set; }


    }
}
