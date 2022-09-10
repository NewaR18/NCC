using System;
namespace tryInd
{
    public class Inde
    {
        public int id=10;
        public string name="Pawan";
        public long phone=9808843569;
        public object this[int n]
        {
            get
            {
                if(n== 0)
                {
                    return id;
                }
                else if (n == 1)
                {
                    return name;
                }
                else if (n == 2)
                {
                    return phone;
                }
                else{
                    return null;
                }
            }
            set
            {
                if (n == 0)
                {
                    id=(int)value;
                }
                else if (n == 1)
                {
                    name=(string)value;
                }
                else if(n == 2)
                {
                    phone=(long)value;
                }
                else
                {
                    id = 0;
                    name = "";
                    phone = 0;
                }
            }
        }
    }
    public class Indexe
    {
        static void Main(string[] args)
        {
            Inde i1=new Inde();
            Console.WriteLine(i1[0]+" "+i1[1]+" "+i1[2]);
            i1[0] = 4;
            i1[1] = "Sudip";
            i1[2] = 9861141726;
            Console.WriteLine(i1[0]+" "+i1[1]+" "+i1[2]);
        }
    }
}