using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeriaVirtual.App.Desktop.Services.Employees
{
    public interface IEmployeeService
    {
        Task<EmployeeCounterViewModel> GetNumberOfEmployees();

        Task<List<EmployeesViewModel>> GetAllEmployees(int pageNumber);
    }
}