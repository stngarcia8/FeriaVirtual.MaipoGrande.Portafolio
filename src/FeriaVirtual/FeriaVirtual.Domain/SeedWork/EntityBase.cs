using System.Collections.Generic;
using FeriaVirtual.Domain.SeedWork.Events;
using FeriaVirtual.Domain.SeedWork.Validations;

namespace FeriaVirtual.Domain.SeedWork
{
    public abstract class EntityBase
    {
        private IList<DomainEventBase> _events;

        public EntityBase() =>
            _events = new List<DomainEventBase>();


        public void Record(DomainEventBase domainEvent)
        {
            if (domainEvent is null) throw new InvalidDomainEventException($"Evento {domainEvent} inválido.");
            _events.Add(domainEvent);
        }

        public IList<DomainEventBase> PullDomainEvents()
        {
            var domainEvents = _events;
            _events = new List<DomainEventBase>();
            return  domainEvents;
        }


        public abstract Dictionary<string, object> GetPrimitives();

        protected static void CheckRule(IBusinessRule rule)
        {
            if (!rule.IsFailed()) return;
            throw new BusinessRuleValidationException(rule);
        }
    }
}
