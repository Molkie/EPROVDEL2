using System;
using System.Collections.Generic;
using System.Text;

namespace ContrabandCars
{
    //CleanCar är en subklass av Car
    class CleanCar : Car
    {
        //Konstruktor för klassen, bygger en bil med 1 - 3 passagerare utan stöldgods.
        public CleanCar()
        {
            //Slumpar passagerare, mellan 1 - 3
            passengers = generator.Next(1, 4);
            //Sätter contrabandAmount till 0.
            contrabandAmount = 0;
        }
    }
}
