using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FactoryPatternIVehicles
{
   public class ConsoleLogger
    {
        public static void VehiclieStartup()
        {
            Console.WriteLine("Start the Vehicle");
            Thread.Sleep(1000);
            
            Console.WriteLine("Put it in gear and GO!!");
            Thread.Sleep(1000);
        }
    }
}
