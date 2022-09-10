using System;
namespace bClass
{
    public class baseClass
    {
        public baseClass(){
            Console.WriteLine("Hello Sudip");
        }
        public baseClass(int i) {
                Console.WriteLine(i);
                Console.WriteLine("Hello Pratik");
        }    
    }
    public class baseClass2 : baseClass
    {
        public baseClass2():base(){
        
        }
        public baseClass2(int i):base(i){ 

        }    
    }
    public class mainp
    {
        static void Main(string[] args)
        {
            baseClass2 sud = new baseClass2();
            baseClass2 sud2 = new baseClass2(5);
        }
        
    }
}