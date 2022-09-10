/*
  Create an interface called compute which has methods add(double x, double y) and diff(double x, double y) to perform addition and substraction of numbers passed as arguments.
  Create a class called Test which implements this interface. Declare instance variables as per requirement in class itself. 
  Create instance of the class Test and demonstrate interface implementation.
  */
using System;
namespace interface3
{
    public interface Compute
    {
        public double add(double x, double y);
        public double subtract(double x, double y);
    }

    public class Test : Compute
    {
        public double add(double x, double y)
        {
            return x + y;
        }
        public double subtract(double x, double y)
        {
            return x - y;
        }
    }
    class Main3
    {
        static void Main(string[] args)
        {
            Test Test = new Test();
            double a = Test.add(5, 6);
            double b = Test.subtract(5, 6);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 8");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}
