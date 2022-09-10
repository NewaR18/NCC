using System;
namespace sortArray
{
    class sorting
    {
        static void Main(string[] args)
        {
            string[] words = new string[10];
            Console.WriteLine("Enter ten words: ");
            for (int i = 0; i < 10; i++)
            {
                words[i] = Console.ReadLine();
            }
            Array.Sort(words);
            Console.WriteLine("The sorted array is: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Lab no: 3");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}