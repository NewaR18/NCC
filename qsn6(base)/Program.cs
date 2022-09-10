using System;
namespace bClass
{
    public class baseClass
    {
        public int age = 18;
        public baseClass()
        {
            Console.WriteLine("Hello Sudip");
        }
        public baseClass(int i)
        {
            Console.WriteLine(i);
            Console.WriteLine("Hello Pratik");
        }
        public virtual void trybase()
        {
            Console.WriteLine("He is " + age);
        }
    }
    public class baseClass2 : baseClass
    {
        public baseClass2() : base()
        {
        }
        public baseClass2(int i) : base(i)
        {
        }
        public override void trybase()
        {
            Console.WriteLine(base.age);
            base.trybase(); //to access value from parent class even after we override it
            Console.WriteLine("Successfuly overridden");
        }
    }
    public class mainp
    {
        static void Main(string[] args)
        {
            baseClass2 sud = new baseClass2();
            baseClass2 sud2 = new baseClass2(5);
            sud2.trybase();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 6");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}