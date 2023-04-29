namespace OOP_Demo
{
    class Calculator
    {

        public void Show()
        {
            Console.WriteLine("This is Show Method");
        }

        public void Sub(int a,int b=0,int c=6)
        {
            Console.WriteLine(a - b - c);
        }
        public void Display(string name)
        {
            Console.WriteLine($"hello {name}");
        }
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public int Cube(int x)
        {
            return x * x * x;

        }
        public int Square(int x)
        {
            return x * x;
        }
        public void Add(int a, int b = 0, int c = 0)
        {
            Console.WriteLine(a + b + c);
        }
        public void divide(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Show();
            calc.Sub(19);
            calc.SayHello("Shree");
            calc.SayHello("");
            calc.Display("Hi hema");
            calc.Sum(160, 20);
            int res = calc.Cube(5);
            Console.WriteLine(res);
            int sq=calc.Square(24);
            Console.WriteLine(sq);
            calc.Add(10, 20, 30);
            calc.divide(80, 40);
        }
    }
}