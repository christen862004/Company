namespace Company.Models
{
    //IOC & DIP
    interface ISort
    {
        void Sort(int[] arr);
    }

    class SelectionSort:ISort
    {
        public void Sort(int[] arr)
        {
            
        }
    }

    class BubbleSort:ISort
    {
        public void Sort(int[] arr)
        {
            //sort this array using Bubblr sort
        }
    }

    class ChrisSort : ISort
    {
        public void Sort(int[] arr)
        {
            throw new NotImplementedException();
        }
    }

    //MyList ==> BubbleSort //dependency
    class MyList //High Level Class
    {
        int[] arr;
        ISort sortAlg; //ref from interface
        public MyList(ISort _sortAlg)//ask give my sort (injection)
        {
            arr = new int[10];
            sortAlg = _sortAlg;// new BubbleSort();//Low Level Class
        }

        public void SortList()
        {
            sortAlg.Sort(arr);
        }
    }



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
            MyList l1 = new MyList(new BubbleSort());
            MyList l2 = new MyList(new SelectionSort());
            MyList l3 = new MyList(new ChrisSort());
            


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
