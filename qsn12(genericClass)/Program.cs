using System;
namespace genericClass
{
    class addOrConcat<T>
    {
        public int x;
        public int y;
        public addOrConcat(T a, T b)
        {
            try
            {
                Console.WriteLine(Convert.ToDouble(a) + Convert.ToDouble(b));
            }
            catch (FormatException)
            {
                Console.WriteLine(a + " " + b);
            }
        }
    }
    public class Maintry
    {
        static void Main(string[] args)
        {
            addOrConcat<int> a1=new addOrConcat<int>(4,5);
            addOrConcat<string> a2 = new addOrConcat<string>("Sudip", "Shrestha");
            addOrConcat<double> a3 = new addOrConcat<double>(4.5, 6.8);
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 12");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");

        }
    }
}