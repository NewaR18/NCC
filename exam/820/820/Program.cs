using System;


namespace Labwork
{
    [AttributeUsage(AttributeTargets.All)]
    public class CustomAttrib : Attribute
    {
        public string name;
        public string action;

        public CustomAttrib(string name, string action)
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
        [CustomAttrib("Modifier", "Assigns value of an object")]
        public void Update(int id, int roll)
        {
            this.id = id;
            this.roll = roll;
        }
        [CustomAttrib("Accessor", "Return value of an object")]
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
            Person sami = new Person();
            sami.Update(8, 20);
            Console.WriteLine("Id Number : " + sami.GetId());
            Console.WriteLine("Roll Number : " + sami.GetRoll());
            Console.WriteLine("Lab no: 17");
            Console.WriteLine("Name : Samima Thapa   Roll No. : 15    Section: B");

        }
    }
}