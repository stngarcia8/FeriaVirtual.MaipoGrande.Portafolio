using FeriaVirtual.App.Desktop.SeedWork.FiltersByCriteria;
using System.Collections.Generic;

namespace FeriaVirtual.App.Desktop.Services.Employees
{
    public class EmployeeFilter
    {
        public IList<Filter> Filters { get; protected set; }


        private EmployeeFilter()
            => Filters = DefineFilters();


        public static EmployeeFilter CreateFilter()
            => new EmployeeFilter();


        private IList<Filter> DefineFilters()
            => new List<Filter> {
                CreateFilter("Todos los empleados", "search_all", "none", false),
                CreateFilter("Mostrar solo administradores", "search_by_profile", 1, false),
                CreateFilter("Mostrar solo consultores", "search_by_profile", 2, false),
                CreateFilter("Mostrar empleados activos", "search_by_status", 1, false),
                CreateFilter("Mostrar empleados inactivos", "search_by_status", 0, false),
                CreateFilter("Filtrar por nombre", "search_by_name", null, true),
                CreateFilter("Filtrar por rut", "search_by_dni", null, true)
            };


        private Filter CreateFilter
            (string filterName, string criteriaType, object criteriaValue, bool requireInput)
        {
            var criteria = new Criteria(criteriaType, criteriaValue, requireInput);
            return new Filter(filterName, criteria);
        }







    }
}
