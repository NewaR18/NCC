using System;
namespace inh
{
    public class Car
    {
        public string tyres;
        public string brakes;
        public double rating;
        public void BasicInfo()
        {
            Console.WriteLine("Rating:" + rating + "\nTyres:" + tyres + "\nBraking:" + brakes);
        }
    }
    public class Mercedes : Car
    {
        public string watermark = "Mercedes";
        public string model;
        public void modelInfo()
        {
            Console.WriteLine("Model:" + model + "\nCompany" + watermark);
        }
    }
    public class test
    {
        static void Main(string[] args)
        {
            Mercedes car1 = new Mercedes();
            car1.model = "G37";
            car1.brakes = "ABS";
            car1.tyres = "Spiky";
            car1.rating = 4.3;
            car1.BasicInfo();
            car1.modelInfo();
        }
    }
}