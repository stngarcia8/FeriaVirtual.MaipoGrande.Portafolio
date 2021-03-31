using FeriaVirtual.Domain.SeedWork.Events;
using System.Collections.Generic;
using System.Text.Json;

namespace FeriaVirtual.Infrastructure.SeedWork.Events
{
    public static class DomainEventJsonSerializer
    {
        public static string Serialize(DomainEventBase domainEvent)
        {
            if (domainEvent == null) {
                return "";
            }
            var attributes = domainEvent.ToPrimitives();
            //attributes.Add("id", domainEvent.EventId.ToString());
            return JsonSerializer.Serialize(new Dictionary<string, Dictionary<string, object>>
            {
                {
                    "data", new Dictionary<string, object>
                    {
                        {"id", domainEvent.EventId.ToString()},
                        {"type", domainEvent.EventName()},
                        {"occurred_on", domainEvent.OcurredOn},
                        {"attributes", attributes}
                    }
                },
                {"meta", new Dictionary<string, object>
                    { {"eventId", domainEvent.EventId.ToString() } }
                }
            });
        }


    }
}
