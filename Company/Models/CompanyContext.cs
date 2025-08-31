using Microsoft.EntityFrameworkCore;

namespace Company.Models
{
    public class CompanyContext:DbContext
    {
        public DbSet<Employee>  Employees { get; set; }
        public DbSet<Department>  Departments { get; set; }
        
        //public CompanyContext():base()
        //{
                
        //}

        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CompanyG2;Integrated Security=True;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Department>().HasData(new Department() { Id=1,Name=".Net",ManagerName="Ahmed" });
            modelBuilder.Entity<Department>().HasData(new Department() { Id=2,Name="UI",ManagerName="Mohamed" });
            modelBuilder.Entity<Department>().HasData(new Department() { Id=3,Name="Fundamental",ManagerName="Karem" });
            modelBuilder.Entity<Employee>().HasData(new Employee() { Id=1,Name="Sara",ImageUrl="2.jpg",Salary=10000,Email="S@gmail.com",DepartmentId=1});
            modelBuilder.Entity<Employee>().HasData(new Employee() { Id=2,Name="Asmaa",ImageUrl="2.jpg",Salary=10000,Email="S@gmail.com",DepartmentId=2});
            modelBuilder.Entity<Employee>().HasData(new Employee() { Id=3,Name="Hassan",ImageUrl="m.png",Salary=10000,Email="S@gmail.com",DepartmentId=3});
            modelBuilder.Entity<Employee>().HasData(new Employee() { Id=4,Name="Mohsen",ImageUrl="m.png",Salary=10000,Email="S@gmail.com",DepartmentId=1});
            base.OnModelCreating(modelBuilder);
        }
    }
}
