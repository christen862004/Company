using Company.Models;
using Company.ViewModels;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace Company.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeController()
        {
            
        }
        public IActionResult Index()
        {
            List<Employee> list = context.Employees.ToList();
            return View("Index", list);
        }

        CompanyContext context = new CompanyContext();
        //Employee/CheckSalary?Salary=1000&Name=Ahmed
        public IActionResult CheckSalary(int Salary,string Name)//NAme =null
        {
            if (Salary % 5 == 0)
                return Json(true);
            else
                return Json(false);
        }

        #region New
        public IActionResult New()
        {
            ViewBag.DeptList = context.Departments.ToList();
            return View("New");
        }

        [HttpPost]//handel only post method request
        [ValidateAntiForgeryToken]//handel local request only (check requ have validd toke or not)
        public IActionResult SaveNew(Employee EmpFromReq)//Department dept,Employee EmpFromReq,string Name,EmpWithDeptListViewModel EmpVM)
        {
            if(ModelState.IsValid==true)
            {
                try
                {
                    context.Employees.Add(EmpFromReq);
                    context.SaveChanges();
                    return RedirectToAction("Index", "Employee");
                }catch(Exception ex)//as validation error not excpeiotn
                {
                    //ModelState.AddModelError("DepartmentId", "Select DEpartment");
                    ModelState.AddModelError("Key1", ex.InnerException.Message);//div
                }
            }
            ViewBag.DeptList = context.Departments.ToList();
            return View("New", EmpFromReq);
        }
        #endregion


        #region Edit
        //Employee/Edit/id
        public IActionResult Edit(int id)
        {
            //Send View Model To View
            //Collect
            Employee empModel=context.Employees.FirstOrDefault(e=>e.Id==id);
            List<Department> DeptList = context.Departments.ToList();
            //declare VM
            EmpWithDeptListViewModel EmpVM = new();
            //Mapping s=>D
            EmpVM.Id = empModel.Id;
            EmpVM.Name = empModel.Name;
            EmpVM.DepartmentId = empModel.DepartmentId;
            EmpVM.ImageUrl = empModel.ImageUrl;
            EmpVM.Salary = empModel.Salary;
            EmpVM.Email = empModel.Email;
            EmpVM.DeptList = DeptList;
            //Send ViewModel
            return View("Edit", EmpVM);
        }

        [HttpPost]
        public IActionResult SaveEdit(EmpWithDeptListViewModel EmpFromReq)
        {
            if(EmpFromReq.Name!=null && EmpFromReq.Salary>7000) {
                //get old ref
                Employee EmpFRomDb =
                    context.Employees.FirstOrDefault(e => e.Id == EmpFromReq.Id);
                //change (set)
                EmpFRomDb.Name = EmpFromReq.Name;
                EmpFRomDb.DepartmentId = EmpFromReq.DepartmentId;
                EmpFRomDb.ImageUrl = EmpFromReq.ImageUrl;
                EmpFRomDb.Salary = EmpFromReq.Salary;
                EmpFRomDb.Email = EmpFromReq.Email;
                //save Change
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            EmpFromReq.DeptList = context.Departments.ToList();
            return View("Edit", EmpFromReq);
        }
        #endregion

        #region     DEtails

        //Employee/DEtails/1?name=ahmed
        //Employee/DEtails?id=1&name=ahmed
        public IActionResult Details(int id,string name)
        {
            //Extra info 
            string message = "Hello";
            int temp = 50;
            string color = "green";
            List<string> brch= new List<string>()
            { "Alex","Assiut","Cairo","Mansoura"};

            //---------------Fill / Set data inside ViewData
            ViewData["Msg"] = message;
            ViewData["Temp"] = temp;
            ViewData["Clr"] = color;
            ViewData["Brch"] = brch;

            ViewBag.Age = 30;//ViewData["Age"]=30;
            ViewBag.Clr = "red";// override on old  ViewData["Clr"] = "red";

            //----------------------------
            Employee empModel= context.Employees.FirstOrDefault(e=>e.Id == id);
            return View("Details",empModel);
            //view with name Details insided Employee Folder
            //Model with type Employee
        }


        public IActionResult DetailsVM(int id)
        {
            //Collect  info's 
            string message = "Hello";
            int temp = 50;
            string color = "green";
            List<string> brch = new List<string>()
            { "Alex","Assiut","Cairo","Mansoura"};
            Employee empModel = context.Employees.FirstOrDefault(e => e.Id == id);

            //---------------Fill / Set data inside ViewModel
            //create obj from VIewModel
            EmpNameWithClrBrachListMsgTempViewModel EmpVM = new();
            //start set info inside VieModel Property (Mapping)
            EmpVM.EmpFullName = empModel.Name;
            EmpVM.EmpId = empModel.Id;
            EmpVM.Temp = temp; ;
            EmpVM.Branches = brch;
            EmpVM.Color = color;
            EmpVM.Msg = message;


            //send ViewModel to View----------------
            return View("DetailsVM", EmpVM);
            //view with name DetailsVM insided Employee Folder
            //Model with type EmpNameWithClrBrachListMsgTempViewModel
        }
        #endregion
    }
}
