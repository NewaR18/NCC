using System;
using System.IO;
using System.Text;
namespace tryFileStream
{
    class FileStream_Class
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("sudipfilestream.txt", FileMode.Create);
            byte[] arr = Encoding.UTF8.GetBytes("Don't panic, you will get the hang of it Sudip");
            fileStream.Write(arr, 0, arr.Length);
            Console.WriteLine("File Created Successfully with energizing statement");
            fileStream.Close();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 13");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}