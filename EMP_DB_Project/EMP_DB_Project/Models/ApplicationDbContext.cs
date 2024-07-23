using Microsoft.EntityFrameworkCore;

namespace EMP_DB_Project.Models
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionstring;

        public ApplicationDbContext(IConfiguration configuration)
        {
            this._configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _connectionstring = _configuration.GetConnectionString("db");
        }
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_connectionstring);

        }
    }
}
