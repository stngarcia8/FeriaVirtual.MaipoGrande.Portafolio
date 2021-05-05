using System;

namespace FeriaVirtual.Domain.SeedWork.Events
{
    public class DomainEventId
    {
        private Guid _id;
        public Guid Value => _id;


        public DomainEventId() =>
            _id = GuidGenerator.NewSequentialGuid();

        public DomainEventId(Guid id) =>
            _id = id;


        public DomainEventId(string id) =>
            _id = new Guid(id);


        public override string ToString() =>
            Value.ToString();


    }
}
