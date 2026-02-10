using EMPLOYEEMANAGEMENT.Models;

namespace EMPLOYEEMANAGEMENT.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee? GetEmployeeById(int id);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
    }
}
