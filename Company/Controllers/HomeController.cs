using Company.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Company.Controllers
{
    /*
     1) class end With Keyword Controller
     2) Class Inherit from Controller Class
     */

    public class HomeController : Controller
    {
        /*
            - Method that found Controller call Action
            1) Must Be Public
            2) Must Be Non Static
            3) Can't be Overload only in one case 
         
         */
        //Home/Method1
        [HttpGet]
        public IActionResult MEthod1()
        {
            return Ok("Method1 Get");
        }
        [HttpPost]
        public IActionResult MEthod1(int age)
        {
            return Ok("Method1 post");
        }


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Home/Welcome
        public string Welcome()
        {
            return "Welcome MVC";
        }
        //class/method
        //Home/ShowMsg
        public ContentResult ShowMsg()
        {
            //logic
            //DEcalte Emp
            ContentResult result = new ContentResult();
            //fill data
            result.Content = "Hello From Controller To View";
            //return
            return result;
        }
        //home/showview
        public ViewResult ShowView()
        {
            //logic
            ViewResult result = new ViewResult();
            result.ViewName = "View1";
            return result;
        }
        //home/ShowMix?id=10&no=1&name=ahmed (QS)
        //home/showMix/10?no=33&name=alaa (QS)
        public IActionResult ShowMix(int no)//,string name,int id)
        {
            if (no != 13)
            {
                //logic
                return View("View1");
            }
            else
            {
                return Content("Hello");
            }

        }

        //public ViewResult View(string viewname)
        //{
        //    ViewResult result = new ViewResult();
        //    result.ViewName = viewname;
        //    return result;
        //}
        /**
         *Action CAn Return
         *1) Content --> ContentREsult  ==>Content
         *2) View    --> ViewResult     ==>view
         *3) Json    --> JsonREsult     ==>json
         *4) NotFound--> NotFounddREsult==>notfound()
         *.........
         
         */









        //Home/index
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
