using Microsoft.AspNetCore.Mvc;

namespace helloworldmvc.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
