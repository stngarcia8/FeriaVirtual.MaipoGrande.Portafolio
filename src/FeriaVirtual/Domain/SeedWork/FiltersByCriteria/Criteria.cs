namespace FeriaVirtual.Domain.SeedWork.FiltersByCriteria
{
    public class Criteria
    {
        public string FieldName { get; }
        public object FieldValue { get; protected set; }


        public Criteria
            (string fieldName, object fieldValue)
        {
            FieldName = fieldName;
            FieldValue = fieldValue;
        }


        public void ChangeFieldValue(object fieldValue)
            => FieldValue = fieldValue;


    }
}
