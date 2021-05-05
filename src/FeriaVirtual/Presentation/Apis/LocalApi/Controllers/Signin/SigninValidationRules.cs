using FluentValidation;

namespace FeriaVirtual.Api.Local.Controllers.Signin
{
    public class SigninValidationRules
        : AbstractValidator<SigninRequest>
    {
        public SigninValidationRules()
        {
            DefineUsernameRules();
            DefinePasswordRules();
        }


        private void DefineUsernameRules()
        {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Nombre de usuario vacío.")
                .NotNull().WithMessage("Nombre de usuario nulo.")
                .MinimumLength(6).WithMessage("Nombre de usuario contiene menos de 6 caracteres de longitud mínima permitida.")
                .MaximumLength(50).WithMessage("Nombre de usuario excede los 50 caracteres de logitud permitida.");
        }


        private void DefinePasswordRules()
        {
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Contraseña vacía.")
                .NotNull().WithMessage("Constraseña nula.")
                .MinimumLength(8).WithMessage("Contraseña tiene menos de los 8 caracteres de longitud mínima permitida.");
        }


    }
}
