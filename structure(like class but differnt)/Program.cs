using System;
namespace trystruct
{
    struct trystruct1
    {
        public int id=0;
        public string name="";
        public string description="";
        public string number="";
        public trystruct1(int id1, string name1, string description1, string number1)
        {
            //Parametrized Constructor
            this.id = id1;
            this.name = name1;
            this.description = description1;
            this.number = number1;
        }
        public trystruct1()
        {
                //Empty Constructor
        }
        public void structfunc1()
        {
            Console.WriteLine(id + " " + name + " " + description + " " + number);
        }
    }
    class main3
    {
        static void Main(string[] args){
            trystruct1 e1=new trystruct1(4,"pratik","Developer","123");
            e1.structfunc1();
            trystruct1 e2 = new trystruct1();
            e2.id = 10;
            e2.name = "Sudip";
            e2.description = "Programmer";
            e2.number = "1232";
            e2.structfunc1();
            trystruct1 e3;
            e3.id = 404;
            e3.name = "Hamza";
            e3.description = "Database_Admin";
            e3.number = "12321";
            e3.structfunc1();
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 9");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}