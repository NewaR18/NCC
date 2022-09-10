using System;
namespace revString
{
    public class reversalString
    {
        static void Main(string[] args)
        {
            string s = "";
            int val=0;
            Console.WriteLine("Enter the string value: ");
            s=Console.ReadLine();
            char[] rev=new char[s.Length];
            for(int i=0; i<rev.Length; i++)
            {
                rev[i] = s[i];
                val++;
            }
            Array.Reverse(rev);
            Console.WriteLine(rev);
            Console.WriteLine("Numer of occurence = "+ val);
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 4");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");

        }
    }
}