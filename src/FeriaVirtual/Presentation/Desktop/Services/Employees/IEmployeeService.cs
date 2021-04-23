using FeriaVirtual.App.Desktop.SeedWork.Filters;
using FeriaVirtual.App.Desktop.Services.Employees.Dto;
using FeriaVirtual.App.Desktop.Services.Employees.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FeriaVirtual.App.Desktop.Services.Employees
{
    public interface IEmployeeService
    {
        Task<string> CreateEmployee(CreateUserDto employeeDto);
        Task<string> UpdateEmployee(UpdateUserDto employeeDto);
        Task<EmployeeCounterViewModel> GetNumberOfEmployees();
        Task<List<EmployeesViewModel>> GetAllEmployees(int pageNumber);
        Task<List<EmployeesViewModel>> GetEmployeesByCriteria(Criteria criteria);


    }
}