using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConstructor
{
    class Phone
    {
        public int IMEI;
        public int height;
        public int width;
        public string processor;
        public string display;
        public Phone(int a, int b, int c, string d, string e)
        {
            IMEI = a;
            height = b;
            width = c;
            processor = d;
            display = e;
        }
        public Phone()
        {
            IMEI = 0;
            height = 0;
            width = 0;
            processor = "";
            display = "";
        }
        public void setValue(int a, int b, int c, string d, string e)
        {
            IMEI = a;
            height = b;
            width = c;
            processor = d;
            display = e;
        }
        public void displayi()
        {
            Console.WriteLine("The specs are: ");
            Console.WriteLine(IMEI);
            Console.WriteLine(height);
            Console.WriteLine(width);
            Console.WriteLine(processor);
            Console.WriteLine(display);
        }
    }
}
