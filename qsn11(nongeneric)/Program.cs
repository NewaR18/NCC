using System;
using System.Collections;
namespace tryNon_Generic
{
    public class tryArrayList
    {
        static void Main(string[] args)
        {
            ArrayList array1 = new ArrayList();
            array1.Add(123);
            array1.Add("Sudip");
            array1.Add("Shrestha");
            array1.Add("Developer");
            foreach (object i in array1)
            {
                Console.WriteLine(i);
            }
            array1.Remove(array1[3]);
            foreach (object i in array1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 11");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}