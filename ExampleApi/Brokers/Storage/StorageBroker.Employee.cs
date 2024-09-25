using ExampleApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleApi.Brokers.Storage
{
    public partial class StorageBroker
    {
        public DbSet<Employee> Employeis { get; set; }
        public ValueTask<Employee> DeleteEmployeeAsync(Employee employee) =>
            this.DeleteAsync<Employee>(employee);

        public ValueTask<Employee> InsertEmployeeAsync(Employee employee) =>
            this.InsertAsync<Employee>(employee);

        public IQueryable<Employee> SelectAllEmployees() =>
            this.SelectAll<Employee>();

        public ValueTask<Employee> SelectEmployeeByIdAsync(int employeeId) =>
            this.SelectAsync<Employee>(employeeId);

        public ValueTask<Employee> UpdateEmployeeAsync(Employee employee) =>
            this.UpdateAsync<Employee>(employee);
    }
}
