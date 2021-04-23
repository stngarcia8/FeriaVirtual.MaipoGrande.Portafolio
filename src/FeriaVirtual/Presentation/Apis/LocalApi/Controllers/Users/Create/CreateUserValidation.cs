using FluentValidation;

namespace FeriaVirtual.Api.Local.Controllers.Users.Create
{
    public class CreateUserValidation
        : AbstractValidator<CreateUserRequest>
    {
        public CreateUserValidation()
        {
            DefineFirstnameRules();
            DefineLastnameRules();
            DefineDniRules();
            DefineProfileIdRules();
            DefineUsernameRules();
            DefinePasswordRules();
            DefineEmailRules();
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


    }
}
