using ExampleApi.Models;
using ExampleApi.Services.Foundation;
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace ExampleApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : RESTFulController
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpPost]
        public async ValueTask<ActionResult<Employee>> PostEmployeeAsync([FromForm] Employee employee)
        {
            var postedEmployee = 
                await this.employeeService.AddEmployeeAsync(employee);
            
            return Created(postedEmployee);
        }

        [HttpGet]
        public async ValueTask<ActionResult<Employee>> GetByIdEmployeeAsync([FromForm] int employeeId)
        {
            var getByIdEmployee =
                await this.employeeService.RetrieveEmployeeByIdAsync(employeeId);

            return Ok(getByIdEmployee);
        }

        [HttpDelete]
        public async ValueTask<ActionResult<Employee>> DeleteEmployeeAsync([FromForm] Employee employee)
        {
            var deletedEmployee = 
                await this.employeeService.RemoveEmployeeByIdAsync(employee);

            return Ok(deletedEmployee);
        }

        [HttpGet]
        public ActionResult<IQueryable<Employee>> GetAllEmployeeAsync()
        {
            var result = 
                this.employeeService.RetrieveAllEmployees();
           
            return Ok(result);
        }

        [HttpPut]
        public async ValueTask<ActionResult<Employee>> UpdateEmployeeAsync([FromForm] Employee employee)
        {
            var updateEmployee =
                await this.employeeService.ModifyEmployeeAsync(employee);

            return Ok(updateEmployee);
        }
    }
}
