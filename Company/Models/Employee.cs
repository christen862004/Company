using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Models
{
    public class Employee
    {
        //[Key]
        public int Id { get; set; }
        
        [Required]//name not null
        [MinLength(3,ErrorMessage ="Name Must be more thna 2 char")]
        [MaxLength(25)]
        public string Name { get; set; }

        [Required]
        [Unique(XYZ ="fdfsd")]
        public string? Email { get; set; }

        //7000:50000
        //[Range(7000,50000)]
        //[Even(ErrorMessage ="Salary Must be even")]
        [Remote("CheckSalary","Employee",AdditionalFields = "Name")]//MVC only
        public int Salary { get; set; }

        //m.jpg | m.png
        [RegularExpression(@"\w+\.(jpg|png)",ErrorMessage ="Image Must be png or jpg")]
        public string? ImageUrl { get; set; }

        [ForeignKey("Department")]
        [Display(Name="Department")]
        public int DepartmentId { get; set; }

        
        public Department? Department { get; set; }

    }
}
