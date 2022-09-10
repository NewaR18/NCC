using System;
using System.IO;
namespace copyFile
{
    class copyAndPaste
    {
        static void Main(string[] args)
        {
            File.Copy("sudiptextreaderwriter.txt", "oneWhereItIsCopied.txt");
            Console.WriteLine(File.ReadAllText("oneWhereItIsCopied.txt"));
        }
    }
}