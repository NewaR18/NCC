using System;
namespace Delegate
{ 
    public delegate void MyDelegate(int a, int b);
    public class tryDelegate1
    {
        public void diff(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Main(string[] args)
        {
            tryDelegate1 md1 = new tryDelegate1();
            MyDelegate try1 = md1.sum;
            MyDelegate try2 = md1.diff;
            MyDelegate try3 = try1 + try2;
            Console.WriteLine("--------------------------");
            try3.Invoke(10, 30);
            Console.WriteLine("--------------------------");
            try3 -= try1;
            try3.Invoke(40, 50);
            Console.WriteLine("--------------------------");
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 10");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}
