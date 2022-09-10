using System;

namespace KS
{
    class demo
    {
        public bool AreEqual(object a, object b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            demo d = new demo();
            bool res = d.AreEqual(2, 2);
            Console.WriteLine(res);

        }
    }

}
