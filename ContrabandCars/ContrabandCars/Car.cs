using System;
using System.Collections.Generic;
using System.Text;

namespace ContrabandCars
{
    //Basklass för alla bilar
    class Car
    {
        //Variabler
        public int passengers;
        public int contrabandAmount;
        public bool alreadyChecked = false;
        public Random generator = new Random();

        //Metod för att examinera bilen
        public bool Examine()
        {
            //Sätter alreadyChecked till true.
            alreadyChecked = true;
            //Om bilen har stöldgods slumpas chansen att man hittar stöldgodset.
            //Kollar om bilen har stöldgods eller inte.
            if (contrabandAmount != 0)
            {
                 //Definerar inten search som ett slumpat tal mellan 1 och 5.
                int search = generator.Next(1, 6);
                //Kollar om search är högre än eller lika med mängden stöldgods.
                //Har man 1 stöldgods blir chansen 1/5 att man hittar stöldgodset...
                //Har man 4 stöldgods blir chansen 4/5 att man hittar stöldgodset...
                if (search <= contrabandAmount)
                {
                    //Om search är under eller lika med contrabandAmount returneras värdet true.
                    return (true);
                }
                else
                {
                    //Om search är under contrabandAmount returneras värdet false.
                    return (false);
                }
                
            }
            //Om bilen inte har något contrabandAmount retureras värdet false automatiskt.
            else
            {
                //Returnar False.
                return (false);
            }

        }
    }


}
