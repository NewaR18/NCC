using System;
namespace trybase
{
    public class robin
    {
        public int id = 10;
        public void inc()
        {
            id++;
            Console.WriteLine(id);
        }
    }
    public class hood : robin
    {
        int id = 50;
        public void mul()
        {
            Console.WriteLine(base.id);
        }
    }
    public class maini
    {
        public static void Main(string[] args)
        {
            hood hi=new hood();
            hi.inc();
            hi.mul();
        }
    }
}