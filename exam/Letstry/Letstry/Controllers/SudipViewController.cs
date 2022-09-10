using Microsoft.AspNetCore.Mvc;
using Letstry.Models;
namespace Letstry.Controllers
{
    public class SudipViewController : Controller
    {
        public IActionResult form()
        {
            return View();
        }
        public IActionResult MyDetails(Sudip s)
        {
            return View(s);
        }
    }
}
