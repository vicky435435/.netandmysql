using EMP_DB_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace EMP_DB_Project.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }


        public async Task<EmployeeDetails> AddEmployee(EmployeeDetails employeeDetails)
        {
            EmployeeDetails employee = new();
            _dbContext.Add(employeeDetails);
            await _dbContext.SaveChangesAsync();
            return employee;
        }

        public async Task<IEnumerable<EmployeeDetails>> GetEmployeeDetails()
        {
            var employeeList = await _dbContext.EmployeeDetails.ToListAsync();
            return employeeList;
        }

    }
}
