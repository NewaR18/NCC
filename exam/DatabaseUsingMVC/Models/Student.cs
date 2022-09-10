using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace DatabaseUsingMVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long PhoneNo { get; set; }
    }
}
