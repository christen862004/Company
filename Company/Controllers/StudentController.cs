using Company.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studentBL = new StudentBL();
        //Controller <==> Moder
        //Controller ==>View
        //Student/All
        public IActionResult All()
        {
            //get Stuent data from Model
            List<Student> StudentsModel= studentBL.GetAll();
            //Send View To Display

            return View("ShowAll",StudentsModel);
            //View : ShowAll ,Model With Type List<student>
            //
        }
       
        //Student/Details?id=1
        //Student/Details/1
        public IActionResult Details(int id)
        {
            Student StdModel= studentBL.GetById(id); //get info
            return View("Details", StdModel);//Boxing
            //View =DEtails , Model : Student
        }


    }
}
