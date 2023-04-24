using System.Transactions;

namespace Duplicate_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 1, 6, 2, 84, 2, 54, 94, 5, 6, 8 };
            int Count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        Count++;
                }
            }
            Console.WriteLine("Number of duplicate elements:" + Count);
        }
    }
}