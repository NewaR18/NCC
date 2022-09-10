using System;
namespace jaggedArray
{
    class demonstrating
    {
        static void Main(string[] args)
        {
            int[][] jArray = new int[2][];
            jArray[0] = new int[4] {10,23,34,11};
            jArray[1] = new int[3] { 68, 45, 32 };
            for (int i = 0; i < jArray.Length; i++)
            {
                Console.WriteLine((i+1) + " element of jagged array: ");
                for (int j = 0; j < jArray[i].Length; j++)
                {
                    Console.Write(jArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 3");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}
