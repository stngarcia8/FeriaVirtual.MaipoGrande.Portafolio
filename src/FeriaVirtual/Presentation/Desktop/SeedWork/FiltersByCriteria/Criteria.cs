namespace FeriaVirtual.App.Desktop.SeedWork.FiltersByCriteria
{
    public class Criteria
    {
        public string CriteriaType { get; } 
        public object CriteriaValue { get; protected set; }
        public bool RequireInput { get; set; }


        public Criteria
            (string criteriaType, object fieldValue, bool requireInput)
        {
            CriteriaType = criteriaType;
            CriteriaValue = fieldValue;
            RequireInput = requireInput;
        }


        public void ChangeFieldValue(object fieldValue)
            => CriteriaValue = fieldValue;


    }
}
