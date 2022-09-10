using System;
namespace tryingBuiltIn
{
    class GFG
    {
        [Obsolete("method1 is obsolete", true)]
        static void method1()
        {
            int a = 65;
            Console.WriteLine(a);
            Console.WriteLine("Roger that");
        }
        public static void Main(string[] args)
        {
            method1(); 
        }
    }
}