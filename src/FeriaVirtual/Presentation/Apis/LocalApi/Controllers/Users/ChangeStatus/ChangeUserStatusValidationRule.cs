using FluentValidation;
using System;

namespace FeriaVirtual.Api.Local.Controllers.Users.ChangeStatus
{
    public class ChangeUserStatusValidationRule
        : AbstractValidator<ChangeUserStatusRequest>
    {
        public ChangeUserStatusValidationRule()
        {
            DefineUserIdRules();
            DefineIsactiveRules();
        }

        private void DefineUserIdRules()
        {
            RuleFor(x => x.UserId)
                .NotEqual(Guid.Empty).WithMessage("Identificador de usuario vacío.");
        }


        private void DefineIsactiveRules()
        {
            RuleFor(x => x.Status)
                .InclusiveBetween(0, 1).WithMessage("Estado del usuario inválido.");
        }


    }
}
