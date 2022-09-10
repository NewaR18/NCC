using System;
namespace arr
{
    public class arra
    {
        static void Main(string[] args)
        {
            int[][] su = new int[3][] { 
                new int[]{ 1, 2 },
                new int[]{ 2, 3,4 },
                new int[]{ 4, 5,7 } };
            for(int i = 0; i < su.Length; i++)
            {
                for(int j = 0; j < su[i].Length; j++)
                {
                    Console.WriteLine(su[i][j]);
                }
            }
        }
    }
}