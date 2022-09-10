using System;

namespace abstraction
{
    public abstract class example //we cannot create object of abstract class
    {
        public int id = 5;
        public abstract void exAbstract();//when we do not know any attributes of the method, then we use abstract method and for that abstract class is compulsory;
    }
    class sudip : example
    {
        public override void exAbstract()
        {
            Console.WriteLine("Sudip Shrestha");
        }
    }
    class mainAbstract
    {
        static void Main(string[] args)
        {
            sudip e1 = new sudip();
            Console.WriteLine(e1.id);
            e1.exAbstract();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 8");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}
