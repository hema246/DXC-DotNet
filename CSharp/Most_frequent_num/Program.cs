namespace Most_frequent_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 7, 7, 7, 8, 8, 8, 5, 5, 5, 5, 6, 6, 6, 6 };
            
            int most_freq_num = 0;
            int num = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }
                if (most_freq_num < count)
                {
                    most_freq_num = count;
                    num= arr[i];
                }   
            }
            Console.WriteLine(num);
        }
    }
}
