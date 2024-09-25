using ExampleApi.Brokers.Storage;
using ExampleApi.Models;

namespace ExampleApi.Services.Foundation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IStorageBroker storageBroker;

        public EmployeeService(IStorageBroker storageBroker) => 
            this.storageBroker = storageBroker;

        public ValueTask<Employee> AddEmployeeAsync(Employee employee) =>
            this.storageBroker.InsertEmployeeAsync(employee);

        public ValueTask<Employee> ModifyEmployeeAsync(Employee employee) =>
            this.storageBroker.UpdateEmployeeAsync(employee);

        public ValueTask<Employee> RemoveEmployeeByIdAsync(Employee employee) =>
            this.storageBroker.DeleteEmployeeAsync(employee);

        public IQueryable<Employee> RetrieveAllEmployees() =>
            this.storageBroker.SelectAllEmployees();


        public ValueTask<Employee> RetrieveEmployeeByIdAsync(int employeeId) =>
            this.storageBroker.SelectEmployeeByIdAsync(employeeId);
    }
}
