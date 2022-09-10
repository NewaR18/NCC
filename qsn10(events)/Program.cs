using System;
namespace tryEvent
{
    public class eventClass
    {
        public delegate void MyDelegate(string message);
        public event MyDelegate Event;
        public void RaiseEvent(string message)
        {
            Event(message);
        }
    }
    class mainEvent
    {
        static void Main(string[] args)
        {
            eventClass eventClass = new eventClass();
            eventClass.Event += new eventClass.MyDelegate(display);
            Console.Write("Enter message: ");
            string msg = Console.ReadLine();
            eventClass.RaiseEvent(msg);
        }
        static void display(string message)
        {
            Console.WriteLine("Message: "+ message);
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 10");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}