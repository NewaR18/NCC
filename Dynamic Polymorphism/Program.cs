using System;
namespace CreateShape
{
    public class shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape.....");
        }
    }
    public class Circle1 : shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle....");
        }
    }
    public class Rectangle : shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle.....");
        }
    }
    public class ShapeTest
    {
        static void Main(string[] args)
        {
            shape s = new shape();
            s.Draw();
            s = new Circle1();
            s.Draw();
            s = new Rectangle();
            s.Draw();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 7");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}
