using System;
using System.Text;
using FluentValidation;
using FluentValidation.Results;

namespace FeriaVirtual.Domain.SeedWork.Validations
{
    public class BusinessRulesValidator<TObject>
        : IBusinessRule
        where TObject : class
    {
        private readonly TObject _entity;
        private readonly AbstractValidator<TObject> _rule;

        public string Message { get; protected set; }


        private BusinessRulesValidator(AbstractValidator<TObject> rule, TObject entity)
        {
            _rule = rule;
            _entity = entity;
            Message = string.Empty;
        }

        public static BusinessRulesValidator<TObject> BuildValidator
            (AbstractValidator<TObject> rule, TObject entity) =>
            new BusinessRulesValidator<TObject>(rule, entity);

        public bool IsFailed()
        {
            var result = _rule.Validate(_entity);
            if (result.IsValid) return false;
            GenerateErrorMessage(result);
            return true;
        }

        private void GenerateErrorMessage(ValidationResult result)
        {
            var errors = new StringBuilder();
            foreach (var error in result.Errors) {
                errors.Append($"-{error.ErrorMessage}{Environment.NewLine}");
            }
            Message = errors.ToString();
        }



    }
}
