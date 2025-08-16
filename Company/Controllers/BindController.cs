using Company.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    public class BindController : Controller
    {
        /*
         /bind/testPrimitive?name=chris&age=33
         <form action="/bind/testPrimitive" method="get">
            <input name=""name">
            <input name="age">
            <input type="submim">
        </form>
         */
        //Bind/TestPrimitive?name=ahmed&age=12&id=10
        //Bind/TestPrimitive/10?name=ahmed&age=12
        //Bind/TestPrimitive/10?name=ahmed&age=12&color[0]=blue&color[1]=red
        public IActionResult TestPrimitive(int age,string name,int id,string[] color)
        {
            return Ok();
        }
        //Collection DataType (list ,dic)
        //Bind/TestDic?name=christen&Phones[ahmed]=123&Phones[mohemd]=456
        public IActionResult TestDic(string name,Dictionary<string,string> Phones)
        {
            return Ok();
        }

        //Complex Type (Custom Class)
        //Bind/TestObj/1?NAme=.Net&ManagerName=Ahmed
        public IActionResult TestObj(Department dept)
        //public IActionResult TestObj
        //    (int Id, string Name, string? ManagerName, List<Employee> Employees)
        {
            return Ok();    
        }
    }
}
