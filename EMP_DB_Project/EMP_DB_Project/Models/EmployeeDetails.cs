using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMP_DB_Project.Models
{
    public class EmployeeDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } = 0;
        public string? Employeedesignation { get; set; }
        public string? Fullname { get; set; }
        public string? Email { get; set; }
        public int age { get; set; }
        public string Dob { get; set; }
        public string? address { get; set; }
        public decimal Salary { get; set; }

    }
}
