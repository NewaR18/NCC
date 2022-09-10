using System;
namespace interface3
{
    public interface Compute
    {
        public double add(double x, double y);
    }
    public interface Compute2
    {
        public double subtract(double x, double y);
    }
    public class Test : Compute
    {
        public double add(double x, double y)
        {
            return x + y;
        }
    }
    public class Test2: Compute2
    {
        public double subtract(double x, double y)
        {
            return x - y;
        }
    }
    public class childTest: Compute , Compute2 
    {
        Test testing1=new Test();
        Test2 testing2=new Test2();
        public double add(double a,double b)
        {
            return testing1.add(a,b);
        }
        public double subtract(double a, double b)
        {
            return testing2.subtract(a, b);
        }
    }
    class Main3
    {
        static void Main(string[] args)
        {
            childTest try1=new childTest();
            double a = try1.add(5, 6);
            double b=try1.subtract(5, 6);
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
