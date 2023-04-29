using System.Runtime.InteropServices;

namespace InterfaceExcercise
{   
    interface IVehiclo
    {
        void Drive();
        bool  Refuel(int x);
    }
    class Car: IVehiclo
    {
        int gasoline;
        public Car(int GasolinetoRefuel)
        {
            gasoline = GasolinetoRefuel;
        }
        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("The car is driving.");
            }
            else
            {
                Console.WriteLine("The car is not driving.");

            }
        }
        public bool Refuel(int gasolineToAdd)
        {
            gasoline += gasolineToAdd;
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Starting amount of gasoline to refuel: ");
            int gasolineToAdd = Convert.ToInt32(Console.ReadLine());
            Car myCar = new Car(0);
            myCar.Refuel(gasolineToAdd);
            myCar.Drive();
        }
    }
}