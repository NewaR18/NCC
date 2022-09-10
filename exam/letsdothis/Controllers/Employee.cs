
using Microsoft.AspNetCore.Mvc;
using letsdothis.Models;
namespace letsdothis.Controllers

{
    public class EmployeeController : Controller
    {
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            return View("DisplayDetails", emp);
        }
    }
}

