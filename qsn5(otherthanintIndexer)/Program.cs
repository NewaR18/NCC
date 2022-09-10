using System;
namespace indexer
{
    class demonstIndexer
    {
        int id;
        int roll;
        public demonstIndexer(int id, int roll)
        {
            this.id = id;
            this.roll = roll;
        }
        public object this[string x]
        {
            get
            {
                if (x == "a")
                {
                    return this.id;
                }
                else if (x == "b")
                {
                    return this.roll;
                }
                else
                {
                    return null;
                }
            }
            set
            {

                if (x == "a")
                {
                    this.id = (int)value;
                }
                else if (x == "b")
                {
                    this.roll = (int)value;
                }
                else
                {
                    this.id = 0;
                    this.roll = 0;
                }
            }
        }
    }
    internal class stringIndexer
    {
        static void Main(string[] args)
        {
            demonstIndexer e1 = new demonstIndexer(3, 20);
            Console.WriteLine("id = " + e1["a"] + "\n" + "Roll No = " + e1["b"]);
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 5");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");

        }
    }
}