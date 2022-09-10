namespace kamal
{
    class kamal2
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2= new Box(2, 10, 20, "Sudip");
            Box box3= new Box();
            box3.id = 100;
            Console.WriteLine(box2.name);
            box1.setValues(3, 20, 40, "holoa");
            Console.WriteLine(box1.name);
            box2.getValues();
            Console.WriteLine(box3.id);
            Console.WriteLine(box1.Radius);
            box1.Radius = 9.8;
            Console.WriteLine(box1.Radius);
        }  
    }
}