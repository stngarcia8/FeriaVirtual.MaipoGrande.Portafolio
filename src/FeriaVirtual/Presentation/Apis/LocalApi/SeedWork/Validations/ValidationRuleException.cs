namespace FeriaVirtual.Api.Local.SeedWork.Validations
{
    [System.Serializable
        ]
    public class ValidationRuleException
        : System.Exception
    {
        public ValidationRuleException(string message)
            : base(message) { }


    }
}
