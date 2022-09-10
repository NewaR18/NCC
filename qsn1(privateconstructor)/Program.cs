using System;
namespace privateConst
{
    public class demonstrate
    {
        public static int i,j;
        private demonstrate()
        {
        }
        public static void demonst()
        {
            Console.WriteLine(i + j);

        }
        public static void Main()
        {
            demonstrate.i = 5;
            demonstrate.j = 6;
            demonstrate.demonst();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Lab no: 1");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}