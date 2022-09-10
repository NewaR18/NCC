using lab26_combineall_.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab26_combineall_.Controllers
{
    public class CombineController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name", "Sudip Shrestha");
            TempData["RollNo"] = 20;
            return View();
        }
        public IActionResult Index2()
        {
            Profile c1 = new Profile();
            c1.Name=HttpContext.Session.GetString("Name");
            c1.Semester = "Sixth";
            var RollNo=TempData["RollNo"];
            return View(c1);
        }
        public IActionResult Index3()
        {
            string Semester = Request.Cookies["Semester"];
            return View("Index3", Semester);
        }
        [HttpPost]
        public IActionResult Index3(IFormCollection form)
        {
            string Semester = form["Semester"].ToString();
            Response.Cookies.Append("Semester", Semester);
            return View("Index3");
        }
        public IActionResult Index5()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index5(Profile x2)
        {
            return RedirectToAction("GetQueryString", new { Name= x2.Name});
        }
        public IActionResult GetQueryString(string name)
        {
            Profile x3 = new Profile()
            {
                Name = name
            };
            return View(x3);
        }
        [HttpGet]
        public IActionResult Index6()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index7(IFormCollection formFields)
        {
            var mssg = formFields["hide"]; 
            string msg = "Message = " + mssg; 
            return Content(msg);
        }
    }
}
