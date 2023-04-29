namespace InheritanceDemo
{

    class Calculator
    {
        public Calculator()
        {
            Console.WriteLine("This Is This");

            static int add(int x, int y)
            {
                return x + y;
            }

            static int mul(int x, int y)
            {
                return x * y;
            }

            static int div(int x, int y)
            {
                return x / y;
            }

            static int sub(int x, int y)
            {
                return x - y;
            }
        }

        class ScientificCalculator : Calculator

        {   
            public ScientificCalculator()
            {
                Console.WriteLine("hi hello");
            }
            static int square(int x)
            {
                return x * x;
            }

            static int cube(int x)
            {
                return x * x;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Calculator calculator = new Calculator();


            }
        }
    }
}