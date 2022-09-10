using System; 
namespace tryLambda
{
    public delegate void Greet(string name); 
    class lab15{
        static void Main(string[] args)
        {
            lab15 ld = new lab15();
            Greet hd = (name) => {Console.WriteLine("Hello " + name + ", How you doing??"); };
            hd("Sudip");
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 15");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}