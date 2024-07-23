using EMP_DB_Project.Models;

namespace EMP_DB_Project.Repository
{
    public interface IEmployeeRepository
    {
        Task<EmployeeDetails> AddEmployee(EmployeeDetails employeeDetails);
        Task<IEnumerable<EmployeeDetails>> GetEmployeeDetails();
    }
}