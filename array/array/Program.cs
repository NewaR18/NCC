using System;

 namespace nothing{
    class array
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { { 10, 5, 6 }, { 1, 2, 3 } };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            // for (int i = 0; i <arr.Length; i++) { 
            // for(int j = 0; j<3; j++)
            // {
            //   Console.WriteLine(arr[i,j]);
            // }




        }
    }

}

     