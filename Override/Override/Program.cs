using System;
namespace overriding
{
    public class override3
    {
        public virtual void method1()
        {
            Console.WriteLine("One to be overridden");
        }
        public void method2()
        {
            Console.WriteLine("One to be hidden");
        }
    }
    public class override4:override3{
        public override void method1()
        {
            Console.WriteLine("Successfully overridden");
        }
        public new void method2()
        {
            Console.WriteLine("Successfully hidden");
        }
    }
    public class main3
    {
        static void Main(string[] args)
        {
            override3 defimain = new override3();
            override4 defi =new override4();
            defimain.method1();
            defi.method1();
            defi.method2();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 7");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}