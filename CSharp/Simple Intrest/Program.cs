namespace Simple_Intrest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Principle value");
            double Principle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Intrest value");
            double Intrest = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Time period");
            int Time_period = Convert.ToInt32(Console.ReadLine());
            double SI = (Principle * Intrest * Time_period) / 100;
            Console.WriteLine(SI);
        }
    }
 }
