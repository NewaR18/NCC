
using System;
namespace solid
{
    class loop
    {
        static void Main(string[] args)
        {
            string[] sudip = { "10", "20", "30" };
            foreach (string i in sudip)
            {
                if (i == "10")
                {
                    Console.WriteLine(i);
                    Console.WriteLine(1);
                }
                if (i == "20")
                {
                    Console.WriteLine(i);
                    Console.WriteLine(2);
                }
                if (i == "30")
                {
                    Console.WriteLine(i);
                    Console.WriteLine("All printed");
                }
            }
        }
    }
}