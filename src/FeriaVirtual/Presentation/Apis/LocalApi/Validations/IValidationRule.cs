namespace FeriaVirtual.Api.Local.Validations
{
    public interface IValidationRule
    {
        string ErrorMessage { get; }
        bool IsFailed();


    }
}
