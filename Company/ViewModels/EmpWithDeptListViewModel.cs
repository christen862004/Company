using Company.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.ViewModels
{
    public class EmpWithDeptListViewModel
    {
        public int Id { get; set; }

        [Display(Name="Employee Name")]
       // [DataType(DataType.Password)]//determine input type
        public string Name { get; set; }

        public string? Email { get; set; }

        public int Salary { get; set; }

        public string? ImageUrl { get; set; }

        public int DepartmentId { get; set; }
    //+
        public List<Department> DeptList { get; set; }
    }
}
