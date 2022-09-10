using System;
namespace ConsoleApplication2
{
    class MyException : Exception
    {
        public MyException()
        {
        }
        public MyException(string message) :  base(message)
        {
        }
        public MyException(string message, Exception inner): base(message, inner)
        {
        }
    }

    class TestMyException
    {
        public static void Main(String[] arg)
        {
            int a,b;
            Console.WriteLine("Enter two number: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Result:{0}", a / b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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