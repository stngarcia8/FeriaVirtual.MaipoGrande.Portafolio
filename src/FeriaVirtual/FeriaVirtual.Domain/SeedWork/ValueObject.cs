using System.Collections.Generic;
using FeriaVirtual.Domain.SeedWork.Validations;

namespace FeriaVirtual.Domain.SeedWork
{
    public abstract class ValueObject
    {
        public abstract Dictionary<string, object> GetPrimitives();

        protected static void CheckRule(IBusinessRule rule)
        {
            if (!rule.IsFailed()) return;
            throw new BusinessRuleValidationException(rule);
        }


    }
}
