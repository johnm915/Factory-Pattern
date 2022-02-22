using System;

namespace FactoryPatternIVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the amount of wheels for the vehicle you want to create");
                input = int.TryParse(Console.ReadLine(), out wheelCount);

            } while (input == false);

           var vehicle= VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();

        }
    }
}
