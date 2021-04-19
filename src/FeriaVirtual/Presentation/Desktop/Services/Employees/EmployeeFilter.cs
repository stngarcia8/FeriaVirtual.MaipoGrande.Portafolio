using FeriaVirtual.App.Desktop.SeedWork.Filters;
using System.Collections.Generic;

namespace FeriaVirtual.App.Desktop.Services.Employees
{
    public class EmployeeFilter
    {
        private IList<string> _filters;
        private IList<Criteria> _criteriaCollection;

        public IList<string> GetFilters => _filters;
        public IList<Criteria> GetCriteriaCollection => _criteriaCollection;


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
            _criteriaCollection = new List<Criteria> {
                new Criteria("search_all", "", 1, false),
                new Criteria("search_by_profile", "Administrador", 0, false),
                new Criteria("search_by_profile", "Consultor", 0, false),
                new Criteria("search_by_status", "Activo", 0, false),
                new Criteria("search_by_status", "Inactivo", 0, false),
                new Criteria("search_by_name", "", 0, true),
                new Criteria("search_by_dni", "", 0, true)
            };


        public Criteria GetCriteriaByIndex(int criteriaIndex) =>
            _criteriaCollection[criteriaIndex];


    }
}
