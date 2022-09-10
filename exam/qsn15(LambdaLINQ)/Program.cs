using System;
using System.Linq;
namespace tryLINQ
{
    public delegate void display(int a);
    public class tryingMyBest
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 6, 7, 9, 8 };
            var res = from oddNum in arr where oddNum % 2 == 1 select oddNum;
            Console.WriteLine("The Odd numbers are: ");
            display s1 = (a) => { Console.Write(a + " "); };
            foreach (int i in res)
            {
                s1(i);
            }
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 15");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}
