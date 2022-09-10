using System;
using System.IO;
namespace streamREadWrite
{
    class tryStreamRead_Write
    {
        static void Main(string[] args)
        {
            StreamWriter txt1 = new StreamWriter("sudiptextreaderwriter.txt");
            txt1.Write("Sky is blue! You have no clue\n");
            txt1.Write("Rose is red! All of us are dead\n");
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