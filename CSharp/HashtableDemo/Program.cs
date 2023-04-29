using System.Collections;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(4, "Four");
            ht.Add(1, "One");
           ht.Add(3, "Three");
            ht.Add(2, "Two");
           ht.Add(5, "Five");

            //Console.WriteLine(list[3]);
            Console.WriteLine(ht.ContainsKey(1));

            foreach (var item in ht.Keys)
            {
                Console.WriteLine($"Key: {item}, Value: {ht[item]}");
            }

        }
    }
}