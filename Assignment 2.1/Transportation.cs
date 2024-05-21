using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._1
{
    //PART 2 
    internal class Transportation
    {
        public string Mode { get; set; }
    }

    class Cars : Transportation
    {
        public string Engine { get; set; }
        public int NumberOfDoors { get; set; }
        public int MPG { get; set; }

    }

    class SportsCars : Cars
        {

        }

            class  Mustang : SportsCars
            {
        
            }

            class Charger : SportsCars
            {

            }

        class DailyDrivers : Cars
        {

        }
        
            class Toyota : DailyDrivers
            {

            }

            class Honda : DailyDrivers
            {

            }


        class HyperCars : Cars
        {

        }
            class Bugatti : HyperCars
            {

            }

            class Lamborghini : HyperCars
            {

            }



}
