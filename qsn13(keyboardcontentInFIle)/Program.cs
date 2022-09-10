using System;
using System.IO;
namespace streamREadWrite
{
    class tryStreamRead_Write
    {
        static void Main(string[] args)
        {
            StreamWriter txt1 = new StreamWriter("sudiptextreaderwriter.txt");
            Console.WriteLine("Enter the content to be inserted: ");
            string s1=Console.ReadLine();
            txt1.WriteLine("The content inserted is: ");
            txt1.Write(s1);
            txt1.WriteLine("\n--------------------------");
            txt1.WriteLine("Lab no: 13");
            txt1.WriteLine("Name: Sudip Shrestha");
            txt1.WriteLine("Roll No./Section : 20/A");
            txt1.WriteLine("--------------------------");
            txt1.Close();
            using (StreamReader txt2 = new StreamReader("sudiptextreaderwriter.txt"))
            {
                Console.WriteLine(txt2.ReadToEnd());
            }
        }
    }
}