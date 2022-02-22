using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternIVehicles
{
   public class ThreeWheelAtv : IVehicle
    {
       public ThreeWheelAtv()
        {

        }
        
       public void Drive()
       {
            ConsoleLogger.VehiclieStartup();
            Console.WriteLine("Now you are 3 wheeling!!");
       }




        
    }
}
