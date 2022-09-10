namespace array10
{
    class array11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arri = new int[n];
            Console.WriteLine("Enter array values: ");
            for (int i = 0; i < n; i++)
            {
                arri[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Printing the values!!");
            for (int i = 0; i < n; i++)
            {
                if ((arri[i] % 3 == 0 || arri[i] % 7 == 0) && i % 2 == 0)
                {
                    Console.WriteLine(arri[i]);
                }
            }
        }
    }
}