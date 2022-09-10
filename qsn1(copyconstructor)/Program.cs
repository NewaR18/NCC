using System;
namespace copyConst
{
    public class demonstrate
    {
        int i, j;
        public demonstrate(int a, int b)
        {
            i = a;
            j = b;
        }
        public demonstrate(demonstrate d1)
        {
            i = d1.i;
            j = d1.j;
        }
        public static void Main()
        {
            demonstrate demonstrate1 = new demonstrate(5, 6);
            demonstrate demonstrate2 = new demonstrate(demonstrate1);
            Console.WriteLine(demonstrate2.i + demonstrate2.j);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Lab no: 1");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}