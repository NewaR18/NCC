using System;
namespace charWordString
{
    public class countString
    {
        public static void Main(string[] args)
        {
            string s;
            int val = 0;
            int count = 0;
            Console.WriteLine("Enter the string value: ");
            s = Console.ReadLine();
            char[] rev = new char[s.Length];
            for (int i = 0; i < rev.Length; i++)
            {
                rev[i] = s[i];
                val++;
            }
            for (int i = 0; i < rev.Length; i++)
            {
                if(Convert.ToString(rev[i])==" ")
                {
                    count++;
                }
            }
            Console.WriteLine("The number of characters in string " + s + " is " + val );
            Console.WriteLine("The number of words in string " + s + " is " + (count+1));
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 4");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");

        }
    }
}