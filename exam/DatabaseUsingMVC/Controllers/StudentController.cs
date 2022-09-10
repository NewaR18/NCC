using Microsoft.AspNetCore.Mvc;
using DatabaseUsingMVC.Models;
using DatabaseUsingMVC.Repository;
using System.Data.SqlClient;
using System;
using System.Web;

namespace DatabaseUsingMVC.Controllers
{
    public class StudentController : Controller
    {
        StudentRepo studentRepo=new StudentRepo();
        public IActionResult form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult form(Student std)
        {
            try
            {
                studentRepo.AddStudent(std);
                return RedirectToAction("Index");
            }catch(SqlException ex)
            {
                return Content(ex.Message);
            }
        }
        public IActionResult Index()
        {
            IEnumerable<Student> stdL = studentRepo.CatchAll();
            return View(stdL);
        }
        public IActionResult editform(int id)
        {
            try
            {
                Student std = studentRepo.GetStudentData(id);
                return View(std);
            }
            catch (SqlException ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult editform(Student std)
        {
            try
            {
                studentRepo.UpdateStudent(std,std.Id);
            }
            catch (SqlException ex)
            {
                return Content(ex.Message);
            }
            return RedirectToAction("Index");
        }
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                Student std = studentRepo.GetStudentData(id);
                studentRepo.DeleteStudent(std, std.Id); ;
            }
            catch (SqlException ex)
            {
                return Content(ex.Message);
            } 
            return RedirectToAction("Index");
        }
    }
}
