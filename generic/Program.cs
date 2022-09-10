using System;
using System.Collections;

namespace ks
{
    public delegate string GreetingDelegate(string name);

    internal class test
    {
     /*   public static string Greet(string name)   //Note:if it is define in main function
        {
            return "hello " + name + " good morning";
        }
     */
        static void Main(string[] args)
        {

           /* GreetingDelegate gd = delegate (string name)   //Note: if there is more than one parameter
              {
                  return "Hello " + name + " Good morning";
              };
           */



            GreetingDelegate gd =name=>       //Note: if there is only one parameter or less then one (statement lambda)
            {
                return "Hello " + name + " Good morning";
            };


         //   GreetingDelegate gd = name => num* num; //(expression lambda)
            


            string str = gd.Invoke("Sudip");
            Console.WriteLine(str);
        }
    }
}
