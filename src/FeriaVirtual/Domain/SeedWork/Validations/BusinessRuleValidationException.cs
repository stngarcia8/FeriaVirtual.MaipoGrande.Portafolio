using System;

namespace FeriaVirtual.Domain.SeedWork.Validations
{
    public class BusinessRuleValidationException
        : Exception
    {
        public BusinessRuleValidationException(string message)
            : base(message) { }


    }
}
