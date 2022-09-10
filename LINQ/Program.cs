using System;
using System.Linq;
using System.Text;
namespace Examples
{
    class LINQDemo
    {
        static void Main(string[] args)
        {
            // Specify the data source.
            int[] scores = new int[] { 200, 92, 89, 60, 100 };

            // LINQ query expression.
            var result1 = from scr in scores where scr > 80 select scr;

            // Execute the query.
            Console.WriteLine("Scores greater than 80 are: ");
            foreach (int i in result1)
            {      
                Console.Write(i + " ");
            }

            //another LINQ
            var result2 = from scr in scores where scr > 80 orderby scr descending select scr;


            Console.WriteLine("\n Scores greater than 80 in descending order : ");
            foreach (int i in result2)
            {
                Console.Write(i + " ");
            }
        }
    }
}