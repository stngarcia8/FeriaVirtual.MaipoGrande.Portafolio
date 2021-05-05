using System;
using System.Collections.Generic;
using System.Globalization;

namespace FeriaVirtual.Domain.SeedWork.ValueObjects
{
    public class IntValueObject
        : ValueObject
    {
        public int Value { get; }


        public IntValueObject(int value) =>
            Value = value;


        public override string ToString() =>
            Value.ToString(NumberFormatInfo.InvariantInfo);

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }

        public override bool Equals(object obj) =>
            this == obj || (obj is IntValueObject item && Value == item.Value);


        public override int GetHashCode() =>
            HashCode.Combine(Value);


    }
}
