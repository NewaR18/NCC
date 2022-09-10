using System;
using System.Collections;
namespace tryGeneric
{
    public class List_T
    {
        static void Main(string[] args)
        {
            List<string> exGeneric = new List<string>();
            exGeneric.Add("123");
            exGeneric.Add("Sudip");
            exGeneric.Add("Shrestha");
            exGeneric.Add("Developer");
            foreach(string x in exGeneric)
            {
                Console.Write(x + "   ");
            }
            Console.WriteLine();
            exGeneric.Remove("Developer");
            foreach (string x in exGeneric)
            {
                Console.Write(x + "   ");
            }
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 11");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}