using System;
namespace tryPartial
{
    public partial class PartialClass
    {
        public int a=5;
        public int b=6;
        public int add()
        {
            return a+b;
        }
    }
    public partial class PartialClass
    {
        public void display()
        {
            Console.Write("The addition of " + a + " and " + b + " is ");
        }
    }
    public class mainTryPratial
    {
        static void Main(string[] args)
        {
            PartialClass c1=new PartialClass();
            c1.display();
            Console.WriteLine(c1.add());
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 9");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}