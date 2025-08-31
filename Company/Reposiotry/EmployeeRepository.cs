using Company.Models;

namespace Company.Reposiotry
{
    public class EmployeeRepository : IEmployeeRepository
    {
        CompanyContext context;
        public EmployeeRepository(CompanyContext _context)
        {
            context = _context;//new CompanyContext();
        }
        //CRUD
        public void Add(Employee obj)
        {
            context.Employees.Add(obj);
            //context.Add(obj);
        }

        public void Delete(int id)
        {
            Employee emp= GetByID(id);
            context.Employees.Remove(emp);
            //context.Remove(emp);
        }

        public void Edit(Employee obj)
        {
            Employee empFromDB= GetByID(obj.Id);
            empFromDB.Name= obj.Name;
            empFromDB.ImageUrl= obj.ImageUrl;
            empFromDB.Salary= obj.Salary;
            empFromDB.Email= obj.Email;
            empFromDB.DepartmentId= obj.DepartmentId;
            
        }

        public List<Employee> GetAll()
        {
            return context.Employees.ToList();
        }

        public Employee GetByID(int id)
        {
            return context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
