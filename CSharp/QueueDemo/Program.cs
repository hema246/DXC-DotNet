using System.Collections;
namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            Console.WriteLine(q.Equals(12));
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(q.Contains(10));
            q.Dequeue();

            Console.WriteLine("After removing");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}