
namespace objects
{
    public class student
    {
        int id, roll;
            public void SetValue(int first,int second)
            {
            id = first;
            roll = second;  
            }
            public void Display()
            {
                Console.WriteLine("The first value is "+id);
                Console.WriteLine("The second value is "+roll);
            }
    }
    public class take
    {
        static void Main(string[] args)
        {
            student student1 = new student();
            Console.WriteLine("Enter first variable: ");
            int first=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second variable: ");
            int second = Convert.ToInt32(Console.ReadLine());
            student1.SetValue(first,second);
            student1.Display();
        }
    }
}