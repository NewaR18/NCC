using System;
namespace bClass
{
    public class baseClass
    {
        public int age = 18;
        //Constructor base keyword
        public baseClass()
        {
            Console.WriteLine("Hello Sudip");
        }
        public baseClass(int i)
        {
            Console.WriteLine(i);
            Console.WriteLine("Hello Pratik");
        }

        //Method base keyword : We know we can use this directly in child class, but we can edit it as
        public virtual void trybase()
        {
            Console.WriteLine("He is "+ age);
        }
    }
    public class baseClass2 : baseClass
    {
        //Constructor base keyword
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
        }

    }
}