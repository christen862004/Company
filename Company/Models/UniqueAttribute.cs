using System.ComponentModel.DataAnnotations;

namespace Company.Models
{
    public class UniqueAttribute:ValidationAttribute
    {
        public string XYZ { get; set; }
        //logic based on db query
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string? UserEmail = value.ToString();

            Employee EmpFromRequest=validationContext.ObjectInstance as Employee;


            CompanyContext context = new CompanyContext();
            Employee? EmpFromDataBase= context.Employees
                .FirstOrDefault(e=>e.Email == UserEmail && e.DepartmentId== EmpFromRequest.DepartmentId);
            if (EmpFromDataBase == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Email Already Exists :(");


        }
    }
}
