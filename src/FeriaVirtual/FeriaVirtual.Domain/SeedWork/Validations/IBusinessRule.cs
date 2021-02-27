namespace FeriaVirtual.Domain.SeedWork.Validations
{
    public interface IBusinessRule
    {
        string Message{get; }
        bool IsFailed();


    }
}
