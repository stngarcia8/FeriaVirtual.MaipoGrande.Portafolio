using FeriaVirtual.Domain.SeedWork.Events;
using FeriaVirtual.Domain.SeedWork.Validations;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.SeedWork
{
    public abstract class EntityBase
    {
        private DomainEventCollection _events;

        public EntityBase() =>
            _events = new DomainEventCollection();


        public void Record(DomainEventBase domainEvent)
        {
            if(domainEvent is null)
                throw new InvalidDomainEventException($"Evento {domainEvent} inválido.");
            _events.AddEvent(domainEvent);
        }

        public DomainEventCollection PullDomainEvents()
        {
            var domainEvents = _events;
            _events = new DomainEventCollection();
            return domainEvents;
        }


        public abstract Dictionary<string, object> GetPrimitives();

        protected static void CheckRule(IBusinessRule rule)
        {
            if(!rule.IsFailed())
                return;
            throw new BusinessRuleValidationException(rule.Message);
        }


    }
}
