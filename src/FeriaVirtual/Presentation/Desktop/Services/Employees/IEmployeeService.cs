using FeriaVirtual.App.Desktop.SeedWork.FiltersByCriteria;
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
        Task<string> ChangeEmployeeStatus(ChangeStatusDto changeStatusDto);
        Task<string> ChangeEmployeePassword(ChangePasswordDto changePasswordDto);

        Task<EmployeeCounterViewModel> GetNumberOfEmployees(Criteria criteria);
        Task<List<EmployeesViewModel>> GetEmployeesByCriteria(Criteria criteria, int limit, int offset);
        Task<EmployeeViewModel> GetEmployeeById(string employeeid);


    }
}