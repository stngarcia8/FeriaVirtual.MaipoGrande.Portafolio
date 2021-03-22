using FluentValidation;

namespace FeriaVirtual.Domain.Models.Users.Rules
{
    sealed class UpdateCredentialRules
        : AbstractValidator<Credential>
    {
        public UpdateCredentialRules()
        {
            DefineCredentialIdRules();
            DefineUsernameRules();
            DefinePasswordRules();
            DefineEmailRules();
            DefineIsactiveRules();
        }


        private void DefineCredentialIdRules()
        {
            RuleFor(x => x.CredentialId)
                .NotNull().WithMessage("Identificador de credencial de usuario nula.");
            RuleFor(x => x.CredentialId.ToString())
                .NotEmpty().WithMessage("Identificador de credencial de usuario vacía.");
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
                .MinimumLength(8).WithMessage("Contraseña tiene menos de los 8 caracteres de longitud mínima permitida.")
                .MaximumLength(50).WithMessage("Contraseña excede los 50 caracteres de logitud permitida.")
                .Matches("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,50}$")
                .WithMessage("Contraseña con formato incorrecto, debe contener símbolos, caracteres en mayusculas , minusculas y números, por ejemplo @Password.1234@");
        }


        private void DefineEmailRules()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email vacío")
                .NotNull().WithMessage("Email nulo.")
                .EmailAddress().WithMessage("Formato de email incorrecto.");
        }


        private void DefineIsactiveRules()
        {
            RuleFor(x => x.IsActive)
                .InclusiveBetween(0, 1).WithMessage("Valor de propiedad IsActive inválida.");
        }


    }
}
