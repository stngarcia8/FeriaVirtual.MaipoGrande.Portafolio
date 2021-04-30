namespace FeriaVirtual.App.Desktop.SeedWork.FiltersByCriteria
{
    public class Filter
    {
        public string FilterName { get; }
        public Criteria FilterCriteria { get; }


        public Filter
            (string filterName, Criteria filterCriteria)
        {
            FilterName = filterName;
            FilterCriteria = filterCriteria;
        }


    }
}
