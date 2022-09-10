using System;
namespace PropertyInjection
{
    public interface text
    {
        void Print();
    }
    class format : text
    {
        public void Print()
        {
            Console.WriteLine("Hello!, trying Dependency Injection");
        }
    }
    public class tryingConstructorInjection
    {
        private text _text;
        public tryingConstructorInjection(text t1)
        {
            this._text = t1;
        }
        public void Print()
        {
            _text.Print();
        }
    }
    public class triedDI
    {
        static void Main(string[] args)
        {
            tryingConstructorInjection cs = new tryingConstructorInjection(new format());
            cs.Print();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 20");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}