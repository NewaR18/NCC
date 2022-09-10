using System;
namespace sudip
{
    public delegate void calc(int a, int b);
    public class clacxul
    {
        public void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void subtract(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public static void Main(string[] args)
        {
            clacxul xw=new clacxul();
            calc c1 = new calc(xw.add);
            calc c2 = new calc(xw.subtract);
            c1.Invoke(5, 6);
            c2.Invoke(5, 6);
            calc c3 = c1 + c2;
            c3.Invoke(10, 2);
            c3 -= c1;
            c3.Invoke(10, 2);
        }
    }
}