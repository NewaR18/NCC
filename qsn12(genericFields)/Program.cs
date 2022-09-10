using System;
namespace genericFields
{
    public class addOrConcat<T>
    {
        public int x=0;
        public double z;
        public T[] data = new T[10];
        public void arrs(T a)
        {
            data[x] = a;
            x++;
        }
        public void Display()
        {
            try
            {
                for (int i = 0; i < data.Length; i++)
                {
                    z += Convert.ToDouble(data[i]);
                }
                Console.WriteLine(z);
            }
            catch (FormatException)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    Console.Write(data[i]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
    public class Maintry
    {
        static void Main(string[] args)
        {
            addOrConcat<int> a1 = new addOrConcat<int>();
            addOrConcat<string> a2 = new addOrConcat<string>();
            addOrConcat<double> a3 = new addOrConcat<double>();
            a1.arrs(10);
            a1.arrs(45);
            a1.arrs(25);
            a1.Display();
            a2.arrs("Sudip");
            a2.arrs("Shrestha");
            a2.arrs("is");
            a2.arrs("Genius");
            a2.Display();
            a3.arrs(4.6);
            a3.arrs(2.3);
            a3.arrs(7.7);
            a3.Display();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 12");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}