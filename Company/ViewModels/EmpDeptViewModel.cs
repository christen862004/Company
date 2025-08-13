using Company.Models;

namespace Company.ViewModels
{
    public class EmpDeptViewModel
    {
        public int EmpId { get; set; }
        public int DeptId { get; set; }

        public string EmpName { get; set; }
        public string DeptName { get; set; }
    }
}
