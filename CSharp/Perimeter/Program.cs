namespace Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length");
            int length = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            int breadth = Convert.ToInt16(Console.ReadLine());
            int perimeter = 2 * (length + breadth);
            Console.WriteLine(perimeter);
        }
    }
}