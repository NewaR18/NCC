using System;
namespace charWordString
{
    public class countString
    {
        public static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter the string value: ");
            s = Console.ReadLine();
            string sub = "$#";
            if(s.IndexOf(sub) ==0 && s.LastIndexOf(sub) == s.Length - sub.Length)
            {
                Console.WriteLine("It starts and ends with given substring");
            }
            else
            {
                Console.WriteLine("It doesn't start and end with given substring");

            }
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 4");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");

        }
    }
}