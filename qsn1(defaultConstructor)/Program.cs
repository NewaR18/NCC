using System;
namespace defConst
{
    public class demonstrate
    {
        int i, j;
        public demonstrate()
        {
            i = 5;
            j = 6;
        }
        public static void Main()
        {
            demonstrate demonstrate1 = new demonstrate();
            Console.WriteLine(demonstrate1.i+demonstrate1.j);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Lab no: 1");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}