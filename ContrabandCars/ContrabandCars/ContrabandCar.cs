using System;
using System.Collections.Generic;
using System.Text;

namespace ContrabandCars
{
    //ContrabandCar är en subklass av Car.
    class ContrabandCar : Car
    {
        //Konstruktor för ContrabandCar
        public ContrabandCar()
        {
            //Slumpar antalet passagerare mellan 1 och 4.
            passengers = generator.Next(1, 5);
            //Slumpar mängden stöldgods mellan 1 och 4.
            contrabandAmount = generator.Next(1, 5);
        }
    }
}
