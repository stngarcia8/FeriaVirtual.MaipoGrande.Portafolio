using System.Collections.Generic;

namespace FeriaVirtual.Domain.SeedWork.FiltersByCriteria
{
    public class Filter
    {
        public Dictionary<string, Criteria> Filters;


        private Filter()
            => Filters = new Dictionary<string, Criteria>();


        public static Filter CreateFilters()
            => new();


        public void AddFilter(string filterName, Criteria criteria)
            => Filters.Add(filterName, criteria);


        public Criteria GetFilter(string filterName)
            => !Filters.ContainsKey(filterName)
            ? null
            : Filters[filterName];


        public void ChangeCriteriaValue
            (string filtername, object fieldValue)
        {
            if(!Filters.ContainsKey(filtername))
                return;
            Filters[filtername].ChangeFieldValue(fieldValue);
        }


    }
}
