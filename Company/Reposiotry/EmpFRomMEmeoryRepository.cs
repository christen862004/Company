using Company.Models;

namespace Company.Reposiotry
{
    public class EmpFRomMEmeoryRepository : IEmployeeRepository
    {
        public void Add(Employee obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Employee obj)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            return new List<Employee> { new Employee { Id = 1, Name = "ahmed" }, new Employee { Id = 2, Name = "Sara" } };
        }

        public Employee GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
