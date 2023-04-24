namespace Average_of_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 7, 4, 5, 6, 7, 8, 2 };
            int sum = 0;
            for (int i=0;i<arr.Length; i++)
            {
                sum += arr[i];
            }
            double average = (double)sum / arr.Length;
            Console.WriteLine("Average:" + average);
        }
    }
}