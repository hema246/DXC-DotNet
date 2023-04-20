namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Temperature in Celcius");
            double Celcius = Convert.ToDouble(Console.ReadLine());
            double Fahrenheit = ((Celcius * 9) / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit" + Fahrenheit);

        }
    }
}