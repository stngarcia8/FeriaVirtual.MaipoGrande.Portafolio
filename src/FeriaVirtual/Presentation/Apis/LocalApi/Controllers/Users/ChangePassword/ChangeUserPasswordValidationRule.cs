using FluentValidation;
using System;

namespace FeriaVirtual.Api.Local.Controllers.Users.ChangePassword
{
    public class ChangeUserPasswordValidationRule
        : AbstractValidator<ChangeUserPasswordRequest>
    {
        public ChangeUserPasswordValidationRule()
        {
            DefineUserIdRules();
            DefinePasswordRules();
        }


        private void DefineUserIdRules()
        {
            RuleFor(x => x.UserId)
                .NotEqual(Guid.Empty).WithMessage("Identificador de usuario vacío.");
        }


        private void DefinePasswordRules()
        {
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Contraseña vacía.")
                .NotNull().WithMessage("Constraseña nula.")
                .MinimumLength(8).WithMessage("Contraseña tiene menos de los 8 caracteres de longitud mínima permitida.")
                .MaximumLength(50).WithMessage("Contraseña excede los 50 caracteres de logitud permitida.")
                .Matches("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,50}$")
                .WithMessage("Contraseña con formato incorrecto, debe contener símbolos, caracteres en mayusculas , minusculas y números, por ejemplo @Password.1234@");
        }


    }
}
