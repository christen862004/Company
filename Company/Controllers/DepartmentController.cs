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

        #region NEw
        public IActionResult New() {
            return View("New");//Model =null
        }
        //Department/SaveNew?Name=ux&ManagerName=Ahmed
        //public IActionResult SaveNew(string Name,string ManagerName)
        //any action mvc can handel requets get | Post
        [HttpPost]//attribute "filtter"
        public IActionResult SaveNew(Department dept)//create object + try to fill property value from re
        {
        //    if (Request.Method == "POST")
        //    {
                if (dept.Name != null)//Server Side Validadtion
                {
                    context.Departments.Add(dept);
                    context.SaveChanges();
                    //Dry call action
                    return RedirectToAction("Index");

                }
                return View("New", dept);//mpddel==DEpartment
        //    }
        }
        #endregion
    }
}
