namespace generic_class
{
    class calculator<T>
    {
        public void Add(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine("result= " + (x + y));
        }
        public void Mul(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine("result =" + (x * y));
        }

        public void Sub(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine("result =" + (x - y));
        }
        public void Div(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine("result =" + (x / y));
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            calculator<float> c1 = new calculator<float>();
            c1.Add(2.7f, 5f);
            c1.Sub(2f, 5f);
            c1.Mul(2f, 5f);
            c1.Div(10f, 5f);
            calculator<int> c2 = new calculator<int>();
            c1.Add(2, 5);
            c1.Sub(2, 5);
            c1.Mul(2, 5);
            c1.Div(10, 5);
        }
    }
}
