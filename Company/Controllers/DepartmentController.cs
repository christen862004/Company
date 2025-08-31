using Company.Models;
using Company.Reposiotry;
using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    public class DepartmentController : Controller
    {
        // CompanyContext context = new CompanyContext();
        IDeptartmentRepository departmentRepository;
        public DepartmentController(IDeptartmentRepository deptrep)
        {
            departmentRepository =  deptrep;
        }
        public IActionResult Index()
        {
            List<Department> DEptListModel= departmentRepository.GetAll();
            return View("Index", DEptListModel);
            //Model ==> Department
        }

        public IActionResult Details(int id)
        {
            Department dept= departmentRepository.GetByID(id);
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
                    departmentRepository.Add(dept);
                    departmentRepository.Save();
                    //Dry call action
                    return RedirectToAction("Index");

                }
                return View("New", dept);//mpddel==DEpartment
        //    }
        }
        #endregion
    }
}
