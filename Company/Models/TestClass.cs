namespace Company.Models
{
    public class TestClass
    {
        public int Add(int x ,int y)
        {
            
            return x + y;
        }

        public void Calc()
        {

            dynamic x = 10;
            dynamic y = "Ahemd";
            dynamic std = new Student();
            std = x + y;//

            string name = "sddf";
            name = "fsdfsdd";

            int a = 10;
            int b = 20;
            Add(a, b);
        }
    }
}
