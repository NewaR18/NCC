//Used in event handling
//Below Program is just a demonstration of how it works
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
            MyDelegate try3 = try1 + try2; //When you want to pass same values in parameter, you can send directly in one by adding them using delegate
            try3.Invoke(10, 30);
            try3 -= try1; //you can also remove added value
            Console.WriteLine();
            try3.Invoke(40, 50);
        }

    }

}
