namespace FeriaVirtual.Api.Local.SeedWork.Validations
{
    public interface IValidationRules
    {
        string ErrorMessage { get; }
        bool IsFailed();


    }
}
