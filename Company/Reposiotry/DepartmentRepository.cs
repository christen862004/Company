using Company.Models;

namespace Company.Reposiotry
{
    public class DepartmentRepository : IDeptartmentRepository

    {
        CompanyContext context;
        public DepartmentRepository(CompanyContext _Context)
        {
            context = _Context;// new CompanyContext();
        }
        //CURD
        public void Add(Department obj)
        {
            context.Departments.Add(obj);
        }

        public void Delete(int id)
        {
            context.Departments.Remove(GetByID(id));
        }

        public void Edit(Department obj)
        {
            Department oldDept = GetByID(obj.Id);
            oldDept.Name= obj.Name;
            oldDept.ManagerName= obj.ManagerName;
        }

        public List<Department> GetAll()
        {
            return context.Departments.ToList();
        }

        public Department GetByID(int id)
        {
            return context.Departments.FirstOrDefault(d => d.Id == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
