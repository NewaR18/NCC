using System;
namespace tryingCustomAttribute
{
    [AttributeUsage(AttributeTargets.All)]
    public class MyAttribute : Attribute
    {
        public string name;
        public string action;
        public MyAttribute(string name, string action)
        {
            this.name = name;
            this.action = action;
        }
        public string Name
        {
            get { return name; }
        }
        public string Action
        {
            get { return action; }
        }
    }
    public class Person
    {
        public int id;
        public int roll;
        [MyAttribute("Modifier", "Assigns value of an object")]
        public void Update(int id, int roll)
        {
            this.id = id;
            this.roll = roll;
        }
        [MyAttribute("Accessor", "Return value of an object")]
        public int GetId()
        {
            return id;
        }
        public int GetRoll()
        {
            return roll;
        }
    }
    public class UseIt
    {
        static void Main(string[] args)
        {
            Person sudip = new Person();
            sudip.Update(8, 20);
            Console.WriteLine("Id Number : " + sudip.GetId());
            Console.WriteLine("Roll Number : " + sudip.GetRoll());
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Lab no: 17");
            Console.WriteLine("Name: Sudip Shrestha");
            Console.WriteLine("Roll No./Section : 20/A");
            Console.WriteLine("--------------------------");
        }
    }
}