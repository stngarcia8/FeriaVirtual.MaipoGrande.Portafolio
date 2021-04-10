using FeriaVirtual.App.Desktop.SeedWork.Filters;
using System.Collections.Generic;

namespace FeriaVirtual.App.Desktop.Services.Employees
{
    public class EmployeeFilter
    {
        private IList<string> _filters;
        private IList<Filter> _criteria;

        public IList<string> GetFilters => _filters;
        public IList<Filter> GetCriteria => _criteria;


        private EmployeeFilter()
        {
            DefineFilterNames();
            DefineFilterCriteria();
        }


        public static EmployeeFilter CreateFilter() =>
            new EmployeeFilter();



        private void DefineFilterNames() =>
            _filters = new List<string> {
                "Todos los empleados",
                "Solo administradores",
                "Solo consultores",
                "Empleados habilitados",
                "Empleados inhabilitados",
                "Filtrar por nombre",
                "Filtrar por DNI"
            };


        private void DefineFilterCriteria() =>
            _criteria = new List<Filter> {
                new Filter("search_all", "", 0),
                new Filter("search_by_profile", "Administrador", 0),
                new Filter("search_by_profile", "Consultor", 0),
                new Filter("search_by_status", "Habilitado", 0),
                new Filter("search_by_status", "Inhabilitado", 0),
                new Filter("search_by_name", "", 0),
                new Filter("search_by_dni", "", 0)
            };


        public void ChangeFilterValue(int index, string newValue)
        {
            var filter = _criteria[index];
            filter.FilterValue = newValue;
            _criteria[index] = filter;
        }


        public void ChangePageNumber(int index, int newPageNumber)
        {
            var filter = _criteria[index];
            filter.PageNumber = newPageNumber;
            _criteria[index] = filter;
        }


    }
}
