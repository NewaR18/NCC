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
        public object this[int x]
        {
            get
            {
                if (x == 0)
                {
                    return this.id;
                }
                else if (x == 1)
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

                if (x == 0)
                {
                    this.id = (int)value;
                }
                else if (x == 1)
                {
                    this.roll = (int)value;
                }
                else
                {
                    this.id = 0;
                    this.roll=0;
                }
            }
        }
    }
    internal class intIndexer
    {
        static void Main(string[] args)
        {
            demonstIndexer e1 = new demonstIndexer(3,20);
            Console.WriteLine("id = " + e1[0] + "\n" + "Roll No = " + e1[1]);
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 5");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");

        }
    }
}