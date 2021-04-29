using FeriaVirtual.Domain.SeedWork.FiltersByCriteria;

namespace FeriaVirtual.Application.Services.Employees.Queries
{
    public class EmployeeFilter
    {
        public Filter Filters { get; }

        public EmployeeFilter()
            => Filters = DefineEmployeeFilters();


        private Filter DefineEmployeeFilters()
        {
            var filters = Filter.CreateFilters();
            filters.AddFilter("search_by_name", new Criteria("FullName", null));
            filters.AddFilter("search_by_dni", new Criteria("Dni", null));
            filters.AddFilter("search_by_profile", new Criteria("ProfileId", 1));
            filters.AddFilter("search_by_status", new Criteria("IsActive", 1));
            filters.AddFilter("search_all", new Criteria("none", ""));
            return filters;
        }







    }
}
