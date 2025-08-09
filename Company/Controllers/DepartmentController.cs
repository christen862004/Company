using Company.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    public class DepartmentController : Controller
    {
        CompanyContext context = new CompanyContext();

        public IActionResult Index()
        {
            List<Department> DEptListModel= context.Departments.ToList();
            return View("Index", DEptListModel);
            //Model ==> Department
        }

        public IActionResult Details(int id)
        {
            Department dept= context.Departments.FirstOrDefault(d => d.Id == id);
            return View("Details", dept);
        }
    }
}
