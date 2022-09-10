using System;
using DemoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using DemoWebApp.Repository;
namespace EmployeeController.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepo empRepo=new EmployeeRepo();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            try
            {
                empRepo.AddEmployee(emp);
                return Content("Data has been inserted sucessfully");
            }
            catch(Exception ex)
            {
                return Content("OOPS!" + ex.Message);
            }
        }

    }
}