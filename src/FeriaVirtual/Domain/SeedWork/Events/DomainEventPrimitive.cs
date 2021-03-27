using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
