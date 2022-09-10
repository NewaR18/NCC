using System;
namespace tryEnum
{
    class Calcul
    {
        public enum operators
        {
            add,
            subtract,
            multiply,
            divide
        }
        public int Calc(int a,int b, operators op)
        {
            if (op == 0)
            {
                return a + b;
            }
            else if (Convert.ToInt32(op) == 1)
            {
                return a - b;
            }
            else if (Convert.ToInt32(op) == 2)
            {
                return a * b;
            }
            else
            {

                return a / b;
            }
        }
    }

    class calcEnum
    {
        static void Main(string[] args)
        {
            Calcul c1 = new Calcul();
            Console.WriteLine(c1.Calc(4 , 7 , Calcul.operators.add));
            Console.WriteLine(c1.Calc(4 , 7 , Calcul.operators.subtract));
            Console.WriteLine(c1.Calc(4 , 7 , Calcul.operators.multiply));
            Console.WriteLine(c1.Calc(8 , 4 , Calcul.operators.divide));
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 9");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}