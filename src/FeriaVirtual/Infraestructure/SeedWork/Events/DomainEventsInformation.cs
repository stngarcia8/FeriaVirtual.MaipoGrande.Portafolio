using FeriaVirtual.Domain.SeedWork.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FeriaVirtual.Infrastructure.SeedWork.Events
{
    public class DomainEventsInformation
    {
        private readonly Dictionary<string, Type> IndexedDomainEvents = new();


        public DomainEventsInformation() =>
            GetDomainTypes().ForEach(eventType => IndexedDomainEvents.Add(GetEventName(eventType), eventType));


        public Type ForName(string name)
        {
            IndexedDomainEvents.TryGetValue(name, out Type value);
            return value;
        }

        public string ForClass(DomainEventBase domainEvent) =>
            IndexedDomainEvents.FirstOrDefault(x => x.Value.Equals(domainEvent.GetType())).Key;


        private string GetEventName(Type eventType)
        {
            var instance = (DomainEventBase)Activator.CreateInstance(eventType);
            return eventType.GetMethod("EventName").Invoke(instance, null).ToString();
        }


        private List<Type> GetDomainTypes()
        {
            var type = typeof(DomainEventBase);
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsAbstract).ToList();
        }



    }
}
