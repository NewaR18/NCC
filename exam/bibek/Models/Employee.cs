using System;
namespace DemoWebApp.Models
{
    public class Employee
    {
        int a = 0;
        public int EmpId
        {
            get;
            set; 
        }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
    }
}