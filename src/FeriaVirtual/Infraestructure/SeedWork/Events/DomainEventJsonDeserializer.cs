using FeriaVirtual.Domain.SeedWork.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Infrastructure.SeedWork.Events
{
    public class DomainEventJsonDeserializer
    {
        private readonly DomainEventsInformation _information;


        public DomainEventJsonDeserializer(DomainEventsInformation information) =>
            _information = information;


        public DomainEventBase Deserialize(string body)
        {
            var eventData = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, object>>>(body);

            var data = eventData["data"];
            var attributes = JsonConvert.DeserializeObject<Dictionary<string, string>>(data["attributes"].ToString());

            var domainEventType = _information.ForName((string)data["type"]);

            var instance = (DomainEventBase)Activator.CreateInstance(domainEventType);

            var domainEvent = (DomainEventBase)domainEventType
                .GetTypeInfo()
                .GetDeclaredMethod(nameof(DomainEventBase.FromPrimitives))
                .Invoke(instance, new object[]
                {
                    attributes["id"],
                    attributes,
                    data["id"].ToString(),
                    data["occurred_on"].ToString()
                });

            return domainEvent;
        }


    }
}
