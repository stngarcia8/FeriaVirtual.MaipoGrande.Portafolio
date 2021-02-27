using System;

namespace FeriaVirtual.Domain.SeedWork.Validations
{
    public class BusinessRuleValidationException
        : Exception
    {
        public IBusinessRule FailedRule { get; }
        public string Details { get; }


        public BusinessRuleValidationException(IBusinessRule rule)
            : base(rule.Message)
        {
            FailedRule = rule;
            Details = FailedRule.Message;
        }

        public override string ToString()
        {
            return $"{FailedRule.GetType().FullName }: {FailedRule.Message }";
        }



    }
}
