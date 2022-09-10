using System;
using System.IO;
namespace BinaryWriter_Reader
{
    class BF
    {
        static void Main(string[] args)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("sudipfile.txt", FileMode.Create));
            bw.Write("Have a great time dude, You are doing fine");
            bw.Write("\n------------------------------------");
            bw.Write("Lab no: 13");
            bw.Write("Name: Sudip Shrestha");
            bw.Write("Roll no./Section : 20/A");
            bw.Write("------------------------------------");
            bw.Close();
            BinaryReader br = new BinaryReader(new FileStream("sudipfile.txt", FileMode.Open));
            Console.WriteLine("String : " + br.ReadString());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadString());
            br.Close();
        }
    }
}