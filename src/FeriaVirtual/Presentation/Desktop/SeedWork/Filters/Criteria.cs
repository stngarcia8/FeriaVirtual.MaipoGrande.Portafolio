namespace FeriaVirtual.App.Desktop.SeedWork.Filters
{
    public class Criteria
    {

        public string CriteriaType { get; }
        public object CriteriaValue { get; set; }
        public int PageNumber { get; set; }
        public bool RequireInput { get; set; }


        public Criteria
            (string criteriatype, string criteriavalue, int pagenumber, bool requireinput)
        {
            CriteriaType = criteriatype;
            CriteriaValue = criteriavalue;
            PageNumber = pagenumber;
            RequireInput = requireinput;
        }


        public void ChangeCriteriaValue(string criteriavalue) =>
            CriteriaValue = criteriavalue;


        public void ChangePageNumber(int pagenumber) =>
            PageNumber = pagenumber;


    }
}
