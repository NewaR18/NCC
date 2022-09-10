using System;
namespace matrixMul
{
    class multiplication
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of row of first array: ");
            int r1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of column of first array: ");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of row of second array: ");
            int r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of column of second array: ");
            int c2 = Convert.ToInt32(Console.ReadLine());
            int[,] fArray=new int[r1,c1];
            int[,] sArray = new int[r2, c2];
            int[,] mulArray = new int[r1, c2];
            if (c1 != r2)
            {
                Console.WriteLine("Multiplication is not possible.");
            }
            else
            {
                Console.WriteLine("Enter elements of first array: ");
                for(int i = 0; i < r1; i++)
                {
                    for(int j = 0; j < c1; j++)
                    {
                        fArray[i,j]=Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Enter elements of second array: ");
                for (int i = 0; i < r2; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        sArray[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        mulArray[i, j] = 0;
                        for(int k = 0; k < c1; k++)
                        {
                            mulArray[i, j] += fArray[i, k] * sArray[k, j];
                        }
                    }
                }
                Console.WriteLine("The multiplication matrix is: ");
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        Console.Write(mulArray[i, j]+ "  ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Lab no: 3");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}
