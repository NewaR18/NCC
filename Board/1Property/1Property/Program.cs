using System;
namespace exam
{
    public class tryProperty
    {
        public int id = 10;
        public int Accessor1
        {
            get
            {
                return id;
            }
            set
            {
                if (value < 20)
                {
                    id = value;
                }
                else
                {
                    Console.WriteLine("Value must be less than 20");
                }
                
            }
        }
    }
    public class tryProperty2
    {
        static void Main(string[] args)
        {
            tryProperty c1 = new tryProperty();
            int id1=c1.id;
            Console.WriteLine(id1);
            c1.id = 25;
            id1= c1.id;
            Console.WriteLine(id1);
        }
    }
}