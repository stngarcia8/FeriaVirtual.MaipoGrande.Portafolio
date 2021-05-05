using System;
using System.Collections.Generic;

namespace FeriaVirtual.Domain.SeedWork.ValueObjects
{
    public class StringValueObject
        : ValueObject
    {
        public string Value { get; }


        public StringValueObject(string value) =>
            Value = value;


        public override string ToString() =>
            Value;

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }

        public override bool Equals(object obj) =>
            this == obj || (obj is StringValueObject item && Value == item.Value);


        public override int GetHashCode() =>
            HashCode.Combine(Value);


    }
}
