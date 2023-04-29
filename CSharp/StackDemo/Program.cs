using System.Collections;
namespace StackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);

            Console.WriteLine(s.Contains(30));
            Console.WriteLine(s.Contains(50));
            Console.WriteLine(s.Contains(55));

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After Remove with Pop Method");
            Console.WriteLine($"{s.Pop()} is popped out");
            
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}