namespace Company.Models
{
   public  class MyController
    {
        object viewdata;
        public object ViewData //public property wrap private filed
        {
            get { return viewdata; }
            set { viewdata = value; }
        }
        public dynamic ViewBag
        {
            get { return viewdata; }
            set { viewdata = value; }
        }


    }
    public class TestClass
    {
        public int Add(int x ,int y)
        {
            //dynamic c = 10;
            //c.age = 90;


            MyController controler = new MyController();
            controler.ViewData = 10;
            int z =int.Parse(controler.ViewData.ToString());

            controler.ViewBag = "10";
            int xx = controler.ViewBag;//casting runtmie
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
