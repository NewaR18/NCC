using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamal
{
    public class Box
    {
        public int id;
        public int height;
        public int length;
        public string name;
        public double _Radius;
        public Box()
        {
            id = 1;
            height = 0;
            length = 0;
            name = "hold";
        }
        public Box(int id1, int height1, int length1, string name2)
        {
            id = id1;
            height = height1;
            length = length1;
            name = name2;
        }
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

        public void setValues(int id1, int height1, int length1, string name2)
        {
            id = id1;
            height = height1;
            length = length1;
            name = name2;
        }
        public void getValues()
        {
            Console.WriteLine(id);
            Console.WriteLine(height);
            Console.WriteLine(length);
            Console.WriteLine(name);
        }
        
    }
}
