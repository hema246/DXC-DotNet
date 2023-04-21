namespace Temp_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temp in Celsius\tTemp in Fahrenheit");
            
            for (int celsius = 0; celsius <= 100;  celsius+=10)
            {
                double Fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius}\t\t{Fahrenheit}");
            }

        }
    }
}