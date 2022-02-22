using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternIVehicles
{
   public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {

        }
        public void Drive()
        {
            ConsoleLogger.VehiclieStartup();
            Console.WriteLine("Now you are moving on two wheels");
            Console.WriteLine("Yeah!!!!!!!");
        }
    }
}
