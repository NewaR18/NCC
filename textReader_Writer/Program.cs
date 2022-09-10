using System;
using System.IO;
namespace textREadWrite
{
    class tryTextRead_Write
    {
        static void Main(string[] args)
        {
            using (TextWriter textWriter = File.CreateText("sudiptextreaderwriter.txt"))
            {
                textWriter.WriteLine("What's up?? sky? or ceiling?");
                textWriter.WriteLine("\n--------------------------");
                textWriter.WriteLine("Lab no: 13");
                textWriter.WriteLine("Name: Sudip Shrestha");
                textWriter.WriteLine("Roll No./Section : 20/A");
                textWriter.WriteLine("--------------------------");
            }
            using (TextReader textReader = File.OpenText("sudiptextreaderwriter.txt"))
            {
                Console.WriteLine(textReader.ReadToEnd());
            }
        }
    }
}