using Microsoft.AspNetCore.Mvc;
using qsn19_MVC_.Models;
namespace qsn19_MVC_.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Display()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Student std)
        {
            if (ModelState.IsValid)
            {
                return View("Details", std);
            }
            else
            {
                return View(std);
            }
        }
    }
}
