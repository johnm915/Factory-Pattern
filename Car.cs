using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternIVehicles
{
   public class Car : IVehicle
   {
        public Car()
        {

        }
        public void Drive()
        {
            ConsoleLogger.VehiclieStartup();
            Console.WriteLine("The Car is moving");
        }


   }
}
 
