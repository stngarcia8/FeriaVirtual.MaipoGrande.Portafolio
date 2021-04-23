using FeriaVirtual.Api.Local.SeedWork;
using FluentValidation;
using FluentValidation.Results;

namespace FeriaVirtual.Api.Local.Validations
{
    public class ValidationRule<TRequest>
        : IValidationRule
        where TRequest : IRequest
    {
        private readonly TRequest _request;
        private readonly AbstractValidator<TRequest> _rule;

        public string ErrorMessage { get; protected set; }


        private ValidationRule
            (AbstractValidator<TRequest> rule, TRequest request)
        {
            _rule = rule;
            _request = request;
            ErrorMessage = string.Empty;
        }


        public static ValidationRule<TRequest> Build
            (AbstractValidator<TRequest> rule, TRequest request)
            => new(rule, request);


        public bool IsFailed()
        {
            var result = _rule.Validate(_request);
            if(result.IsValid)
                return false;
            GenerateErrorMessage(result);
            return true;
        }


        private void GenerateErrorMessage(ValidationResult result)
        {
            var errors = new System.Text.StringBuilder();
            foreach(var error in result.Errors) {
                errors.Append($"-{error.ErrorMessage}{System.Environment.NewLine}");
            }
            ErrorMessage = errors.ToString();
        }


    }
}
