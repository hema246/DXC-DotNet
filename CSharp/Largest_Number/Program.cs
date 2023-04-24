namespace Largest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 4, 5, 6, 8, 2, 3, 1 };
            int large=1;

            for(int i=1; i<arr.Length; i++)
            {
                if (large < arr[i])
                    large = arr[i];
            }
            Console.WriteLine("Large Element:"+large);
        }
    }
}   