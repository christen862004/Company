namespace Company.Models
{
    //BL REad /Write List
    public class StudentBL
    {
        //static List
        List<Student> Students;
        public StudentBL()
        {
            Students = new List<Student>() { 
                new Student(){ Id=1,Name="Ahmed",Address="Alex",ImageURL="m.png"},
                new Student(){ Id=2,Name="Asmaa",Address="Alex",ImageURL="2.jpg"},
                new Student(){ Id=3,Name="Heba",Address="Alex",ImageURL="2.jpg"},
                new Student(){ Id=4,Name="Abdo",Address="Alex",ImageURL="m.png"}
            };
        }

        //CRUD  "Create  - REad - Update - Delete"

        public Student GetById(int id)
        {
            return Students.FirstOrDefault(s => s.Id == id);
        }

        public List<Student> GetAll() {
            return Students;
        }
    }
}
