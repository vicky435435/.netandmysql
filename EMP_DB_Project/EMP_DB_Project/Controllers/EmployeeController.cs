using EMP_DB_Project.Models;
using EMP_DB_Project.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EMP_DB_Project.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }


        [HttpPost]
        public async Task<IActionResult> AddEmployeee(EmployeeDetails employeeDetails)
        {
            try
            {
                var employee = _employeeRepository.AddEmployee(employeeDetails);
                return CreatedAtAction(nameof(AddEmployeee), employee);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployeee()
        {
            try
            {
                var employee = await _employeeRepository.GetEmployeeDetails();
                return Ok(employee);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
