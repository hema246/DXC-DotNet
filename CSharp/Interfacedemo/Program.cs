namespace Interfacedemo
{   
    interface ImyInterface
    {
         void sum(int x,int y);
         void divide(int x,int y);

    }
    class Class1:ImyInterface
    {
        public void sum(int x,int y)
        {
            Console.WriteLine(x + y);
        }
        public void divide(int x,int y)
        {
            Console.WriteLine(x / y);

        }
    }
    class Class2:Class1,ImyInterface
    {
        public void cube(int x)
        { 
            Console.WriteLine(x*x*x);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.divide(8,2);
            Class2 c = new Class2();
            c.cube(9);
        }
    }
}