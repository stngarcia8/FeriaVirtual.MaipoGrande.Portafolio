using System;
using System.Text;
using FluentValidation;
using FluentValidation.Results;

namespace FeriaVirtual.Domain.SeedWork.Validations
{
    public class BusinessRulesValidator<TEntity>
        : IBusinessRule
        where TEntity : EntityBase
    {
        private readonly TEntity _entity;
        private readonly AbstractValidator<TEntity> _rule;

        public string Message { get; protected set; }


        private BusinessRulesValidator(AbstractValidator<TEntity> rule, TEntity entity)
        {
            _rule = rule;
            _entity = entity;
            Message = string.Empty;
        }

        public static BusinessRulesValidator<TEntity> BuildValidator
            (AbstractValidator<TEntity> rule, TEntity entity) =>
            new BusinessRulesValidator<TEntity>(rule, entity);

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
