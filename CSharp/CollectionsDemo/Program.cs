using System.Collections;

    namespace CollectionsDemo
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                ArrayList list = new ArrayList();
                list.Add(10);
                list.Add(20);
                list.Add("Hello");
                list.Add(2.5f);
                list.Add(true);               

                foreach (object i in list)
                {
                    Console.WriteLine(i);
                }

                list.Insert(2, "World");

                Console.WriteLine("After Insert");
                foreach (var i in list)
                {
                    Console.WriteLine(i);
                }
               
                Console.WriteLine(list.Count);
            Console.WriteLine("After clearing:");
            list.Clear();
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
        }
    }