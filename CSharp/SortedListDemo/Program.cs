using System.Collections;

namespace SortedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();
            list.Add(4, "Four");
            list.Add(1, "One");
            list.Add(3, "Three");
            list.Add(2, "Two");
            list.Add(5, "Five");

            //Console.WriteLine(list[3]);
            Console.WriteLine(list.GetKey(1));
           Console.WriteLine(list.GetKey(3));
            Console.WriteLine(list.GetByIndex(2));
          Console.WriteLine(list.ContainsKey(2));
            Console.WriteLine(list.ContainsValue(5));
            foreach (var item in list.Keys)
            {
                Console.WriteLine($"Key: {item}, Value: {list[item]}");
                
            }

            Console.WriteLine(list.Clone());  
            foreach (var item in list.Keys)
            {
                Console.WriteLine($"{item}, list{ item}");

            }
        }
            
    }
}