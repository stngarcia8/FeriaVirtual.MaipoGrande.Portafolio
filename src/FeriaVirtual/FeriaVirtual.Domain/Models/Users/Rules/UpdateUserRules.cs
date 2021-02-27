using System;
using FluentValidation;

namespace FeriaVirtual.Domain.Models.Users.Rules
{
    sealed class UpdateUserRules
        : AbstractValidator<User>
    {
        public UpdateUserRules()
        {
            DefineUserIdRules();
            DefineFirstnameRules();
            DefineLastnameRules();
            DefineDniRules();
            DefineProfileIdRules();
        }

        private void DefineUserIdRules()
        {
            RuleFor(x => x.UserId)
                .NotEqual(Guid.Empty).WithMessage("Identificador de usuario vacío.");
        }

        private void DefineFirstnameRules()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("Nombre vacío.")
                .MinimumLength(3).WithMessage("Nombre contiene menos de 3 caracteres mínimos permitidos.")
                .MaximumLength(50).WithMessage("Nombre excede los 50 caracteres máximos permitidos.");
        }

        private void DefineLastnameRules()
        {
            RuleFor(x => x.LastName)
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


    }
}
