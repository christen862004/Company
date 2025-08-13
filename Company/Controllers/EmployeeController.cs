using Company.Models;
using Company.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeController()
        {
            
        }
        CompanyContext context = new CompanyContext();
        //Employee/DEtails/1
        //Employee/DEtails?id=1
        public IActionResult Details(int id)
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

    }
}
