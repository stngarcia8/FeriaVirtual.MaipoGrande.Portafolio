namespace FeriaVirtual.App.Desktop.SeedWork.Filters
{
    public class Filter
    {

        public string FilterType { get; }
        public object FilterValue { get; set; }
        public int PageNumber { get; set; }


        public Filter
            (string filtertype, string filtervalue, int pagenumber)
        {
            FilterType = filtertype;
            FilterValue = filtervalue;
            PageNumber = pagenumber;
        }



    }
}
