using System;
namespace whySoSerious
{
    public class chill
    {
        static void Main(string[] args)
        {
            try
            {
                printArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n"+ ex.Message);
            }
            finally
            {
                Console.WriteLine("\n--------------------------");
                Console.WriteLine("Lab no: 16");
                Console.WriteLine("Name: Sudip Shrestha");
                Console.WriteLine("Roll No./Section : 20/A");
                Console.WriteLine("--------------------------");

            }
        }

        static void printArray()
        {
            int[] arr=new int[4] {4,5,6,7};
            try
            {
                Console.Write("Which array element do you want to print: ");
                int x=Convert.ToInt32(Console.ReadLine());
                Console.Write(arr[x]);
            }
            catch (Exception e1)
            {
                throw;
            }
        }
    }
}