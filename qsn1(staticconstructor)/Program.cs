using System;
namespace staticConst
{
    public class demonstrate
    {
        int i, j;
        static demonstrate()
        {
            Console.WriteLine("Lets assign i to 5 and j to 6");
        }
        public demonstrate(int a, int b)
        {
            i = a;
            j = b;
        }
        public static void Main()
        {
            demonstrate demonstrate1 = new demonstrate(5, 6);
            Console.WriteLine(demonstrate1.i + demonstrate1.j);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Lab no: 1");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}