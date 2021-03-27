using System;
using System.Collections.Generic;
using System.Linq;

namespace FeriaVirtual.Infrastructure.SeedWork.Events
{
    public class DomainEventSubscribersInformation
    {
        private readonly Dictionary<Type, DomainEventSubscriberInformation> _information;


        public DomainEventSubscribersInformation(Dictionary<Type, DomainEventSubscriberInformation> information) => 
            _information = information;


        public Dictionary<Type, DomainEventSubscriberInformation>.ValueCollection All() => 
            _information.Values;



    }
}
