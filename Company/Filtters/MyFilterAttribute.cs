using Microsoft.AspNetCore.Mvc.Filters;

namespace Company.Filtters
{
    public class MyFilterAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }
    }
}
