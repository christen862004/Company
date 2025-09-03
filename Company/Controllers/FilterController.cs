using Company.Filtters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Company.Controllers
{
    [HandelError]
    [Authorize]
    public class FilterController : Controller
    {
        //[HandelError]
        //[MyFilter]
        [AllowAnonymous]
        public IActionResult Index()
        {
          throw new NotImplementedException();
        
        }
        //[HandelError]
        [Authorize]
        public IActionResult Index2()
        {
            throw new NotImplementedException();

        }
    }
}
