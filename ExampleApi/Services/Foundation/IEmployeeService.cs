using ExampleApi.Models;

namespace ExampleApi.Services.Foundation
{
    public interface IEmployeeService
    {
        ValueTask<Employee> AddEmployeeAsync(Employee employee);
        IQueryable<Employee> RetrieveAllEmployees();
        ValueTask<Employee> RemoveEmployeeByIdAsync(Employee employee);
        ValueTask<Employee> RetrieveEmployeeByIdAsync(int employeeId);
        ValueTask<Employee> ModifyEmployeeAsync(Employee employee);
    }
}
