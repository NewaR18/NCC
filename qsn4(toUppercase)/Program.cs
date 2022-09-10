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
            int indexComma=s.IndexOf(',');
            int[] val=new int[indexComma];
            char[] val2=new char[indexComma];
            for(int i = 0; i < indexComma; i++)
            {
                val[i]=Convert.ToInt32(s[i] - 32); //should have used toUpper() "would have been short and better"
            }
            for (int i = 0; i < indexComma; i++)
            {
                val2[i] = Convert.ToChar(val[i]);
            }
            Console.Write(val2);
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 4");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");

        }
    }
}