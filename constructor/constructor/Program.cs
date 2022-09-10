namespace testConstructor
{
    class construct
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone();
            phone1.height = 10;
            Console.WriteLine(phone1.height);
            Phone phone2= new Phone(23, 90,60,"8Gen1","OLED");
            Console.WriteLine(phone2.height);
            phone1.setValue(10,20,30,"A15","QLED");
            phone1.displayi();
            phone2.displayi();
        }
    }
}
