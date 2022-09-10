using System;
namespace exceptionHandling
{
    public class tryingExceptions
    {
        
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two number: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(a + " divide by "+ b + " is " + a / b);
            }catch(DivideByZeroException e1)
            {
                Console.WriteLine("Just found '" + e1.Message + "' error");
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
    }
}