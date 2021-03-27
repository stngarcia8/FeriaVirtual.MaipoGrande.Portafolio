using FeriaVirtual.Domain.SeedWork.Events;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace FeriaVirtual.Infrastructure.SeedWork.Events
{
    public class InMemoryApplicationEventBus
        : IEventBus
    {
        private readonly IServiceProvider _serviceProvider;


        public InMemoryApplicationEventBus(IServiceProvider serviceProvider) =>
            _serviceProvider = serviceProvider;


        public void Publish(DomainEventCollection  eventCollection)
        {
            if (eventCollection is null) {
                return;
            }
            using var scope = _serviceProvider.CreateScope();
            foreach (var @event in eventCollection.GetEvents) {
                var subscribers = GetSubscribers(@event, scope);
                foreach (var subscriber in subscribers) ((IDomainEventSubscriberBase)subscriber).On(@event);
            }
        }

        private static IEnumerable<object> GetSubscribers(DomainEventBase @event, IServiceScope scope)
        {
            var eventType = @event.GetType();
            var subscriberType = typeof(IDomainEventSubscriber<>).MakeGenericType(eventType);
            return scope.ServiceProvider.GetServices(subscriberType);
        }
    }
}
