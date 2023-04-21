namespace Temp__convertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temperature in Degree Celsius:");
            double Celsius = Convert.ToDouble(Console.ReadLine());
            String ch;
            do
            {
                double Fahrenheit = (Celsius * 9) / 5 + 32;

                Console.WriteLine("Temperature (Celsius):" + Celsius);
                Console.WriteLine("Temperature (Fahrenheit)" + Fahrenheit);

                Console.WriteLine("Do you wish to continue(y/n)?");
                 ch =Console.ReadLine();

            }
            while (ch == "y");
        }
    }
}