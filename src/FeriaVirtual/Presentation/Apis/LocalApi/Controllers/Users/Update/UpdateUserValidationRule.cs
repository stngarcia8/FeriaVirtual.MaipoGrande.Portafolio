using FluentValidation;
using System;

namespace FeriaVirtual.Api.Local.Controllers.Users.Update
{
    public class UpdateUserValidationRule
        : AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserValidationRule()
        {
            DefineUserIdRules();
            DefineFirstnameRules();
            DefineLastnameRules();
            DefineDniRules();
            DefineProfileIdRules();

            DefineCredentialIdRules();
            DefineUsernameRules();
            DefineEmailRules();
            DefineIsactiveRules();
        }


        private void DefineUserIdRules()
        {
            RuleFor(x => x.UserId)
                .NotEqual(Guid.Empty).WithMessage("Identificador de usuario vacío.");
        }


        private void DefineFirstnameRules()
        {
            RuleFor(x => x.Firstname)
                .NotEmpty().WithMessage("Nombre vacío.")
                .MinimumLength(3).WithMessage("Nombre contiene menos de 3 caracteres mínimos permitidos.")
                .MaximumLength(50).WithMessage("Nombre excede los 50 caracteres máximos permitidos.");
        }


        private void DefineLastnameRules()
        {
            RuleFor(x => x.Lastname)
                .NotEmpty().WithMessage("Apellido vacío.")
                .MaximumLength(50).WithMessage("Apellido excede los 50 caracteres máximoss permitidos.");
        }


        private void DefineDniRules()
        {
            RuleFor(x => x.Dni)
                .NotEmpty().WithMessage("Dni/Rut vacío.")
                .NotNull().WithMessage("Dni/Rut nulo.")
                .MaximumLength(20).WithMessage("Dni/Rut excede los 20 carcteres permitidos.")
                .Matches("^([0-9]+-[0-9Kk])$").WithMessage("Formato de dni/rut incorrecto");
        }


        private void DefineProfileIdRules()
        {
            RuleFor(x => x.ProfileId)
                .InclusiveBetween(1, 6)
                .WithMessage("Identificador de tipo de usuario inválido.");
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
