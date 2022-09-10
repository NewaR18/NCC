namespace calc
{
    class calculator
    {
        static void Main(string[] args)
        {
            int num1 = 100, num2 = 15;
            string div="";
            Console.WriteLine("Enter first number and second number: ");
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ER)
            {
                Console.WriteLine(ER.Message);
                Console.WriteLine("Defaul value is set as 100 and 15");
            }
            Console.WriteLine("Enter 1 for addition!!");
            Console.WriteLine("Enter 2 for substraction!!");
            Console.WriteLine("Enter 3 for multiplication!!");
            Console.WriteLine("Enter 4 for division!!");
            Console.WriteLine("Enter 5 for Modular arithmetic!!");
            do
            {
                Console.Write("Enter the number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("The addition of " + num1 + " and " + num2 + " is " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("The difference of " + num1 + " and " + num2 + " is " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("The multiplication of " + num1 + " and " + num2 + " is " + (num1 * num2));
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine("The division of " + num1 + " and " + num2 + " is " + (num1 / num2));
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 5:
                        Console.WriteLine("The mod of " + num1 + " and " + num2 + " is " + (num1 % num2));
                        break;
                }
                Console.Write("Do you want to continue(y/n): ");
                div = (Console.ReadLine());   
            }while (div == "y");
            
            /*
            Console.Write("Enter the operation: ");
            int f1=Convert.ToInt32(Console.ReadLine());
            string op=Console.ReadLine();
            int f2=Convert.ToInt32(Console.ReadLine());
            if (op == "+")
            {
                Console.WriteLine(f1 + f2);
            }else if(op == "-")
            {
                Console.WriteLine(f1 - f2);
            }
            else if (op == "*")
            {
                Console.WriteLine(f1 * f2);
            }
            else if (op == "/")
            {
                Console.WriteLine(f1 / f2);
            }
            else if (op == "%")
            {
                Console.WriteLine(f1 % f2);
            }
            else
            {
                Console.WriteLine("Invalid sequence");
            }
            */
        }
    }
}