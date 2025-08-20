using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Models
{
    public class Employee
    {
        //[Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Email { get; set; }

        public int Salary { get; set; }

        public string? ImageUrl { get; set; }

        [ForeignKey("Department")]
        [Display(Name="Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

    }
}
