using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    public class RouteController : Controller
    {
        //Route/MEthod1?name=ahmed
        //r1/12/ahmed   ==>3 segment ,name,age segmanet (route Vlaue)
        //r1/22/ali
        //r1/33/basma
        [Route("r1/{age:int}/{name?}")]//the only way to reach to this action
        public IActionResult Method1(string name,int age=10)
        {
            return Content("M1");
        }


        //Route/MEthod2
        //r2
        public IActionResult Method2()
        {
            return Content("M2");
        }
    }
}
