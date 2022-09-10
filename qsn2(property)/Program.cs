using System;
using System.Collections.Generic;
using System.Linq;
using System;
namespace demonstrateProperty
{
    public class Box
    {
        private double _Radius;
        public double Radius
        {
            set
            {
                _Radius = value;
            }
            get
            {
                return _Radius;
            }
        }
        public static void Main()
        {
            Box box1 = new Box();
            box1.Radius = 20.3;
            Console.WriteLine(box1._Radius);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Lab no: 2");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}
