using System;
using System.Collections.Generic;

namespace ContrabandCars
{
    class Program
    {
        //Lista för bilar
        public static List<Car> cars = new List<Car>();
        //Slumpgenerator
        public static Random generator = new Random();

        static void Main(string[] args)
        {
            //Kallar metoden StartMenu
            StartMenu();
            //Kallar metoden SearchCar
            SearcCar();


            Console.ReadLine();
        }

        public static void SearcCar()
        {
            //Frågar användaren vilken bil denne vill ha.
            Console.WriteLine("Vilken bil vill du titta på?");
            //Låter användaren skriva ett antal
            string nmbr = Console.ReadLine();
            //Kollar om svaret går att överesätta till en int
            bool succes = int.TryParse(nmbr, out int result);

            //Kollar om bool succes är true samt att result inte är utanför cars index.
            if(succes == true && result <= cars.Count && result > 0)
            {
            //Kallar metoden Examine i bilen vars index motsvarar result från listan cars.
            //Kollar om alreadyChecked är false.
            if(cars[result - 1].alreadyChecked == false)
            {
                //Kör metoden Examine och sparar resultatet i bool found.
                bool found = cars[result - 1].Examine();
                //Om bool found är true får användaren ett meddelande.
                if(found == true)
                {
                    //Förklarar hur mycket stöldgods som hittades.
                    Console.WriteLine(cars[result - 1].contrabandAmount + " stöldgods hittades!");
                    Console.ReadLine();
                    Console.Clear();
                    //Kör metoden igen.
                    SearcCar();
                }
                //Om bool found är false får användaren ett meddelande.
                else
                {
                    Console.WriteLine("Inget stöldgods hittades.");
                    Console.ReadLine();
                    Console.Clear();
                    //Kör metoden igen.
                    SearcCar();
                }
            }
            //om alreadyChecked är true kan man inte titta på bilen igen.
            else
            {
                Console.WriteLine("Den bilen har du redan tittat på!");
                Console.ReadLine();
                Console.Clear();
                //Kör metoden igen.
                SearcCar();
            }
            }
            //Om succes är false får användaren skriva igen.
            else
            {
                Console.WriteLine("Den bilen finns inte!");
                Console.ReadLine();
                Console.Clear();
                SearcCar();
            }

        }

        public static void StartMenu()
        {
            //Instruktioner till användaren.
            Console.WriteLine("Hur många bilar vill du ha?");
            //Låter användaren skriva ett antal
            string amount = Console.ReadLine();
            //Kollar om svaret går att överesätta till en int
            bool succes = int.TryParse(amount, out int result);
            //Kollar om succes är true samt att result är över 0.
            if (succes == true && result > 0)
            {
                //For loop som körs så många gånger som användaren skrev.
                for (int i = 0; i < result; i++)
                {
                    //Slumpar om bilen blir en ContrabandCar eller CleanCar.
                    //Slumpar ett tal mellan 1 och 4 och sparar det i int x.
                    int x = generator.Next(1, 5);
                    //Om x är över 3 blir bilen en ContrabandCar.
                    if(x > 3)
                    {
                        //Skapar bilen.
                        ContrabandCar newCar = new ContrabandCar();
                        //Lägger till bilen i listan över bilar.
                        cars.Add(newCar);
                    }
                    //Om x är under eller lika med 3 blir bilen en vanlig bil (CleanCar)
                    else
                    {
                        //Skapar bilen.
                        CleanCar newCar = new CleanCar();
                        //Lägger till bilen i listan över bilar.
                        cars.Add(newCar);
                    }
                }
                //Instruktioner till användaren.
                Console.WriteLine("Skapade " + result + " bilar!");
                Console.ReadLine();
                //Rensar konsollen
                Console.Clear();
            }
            //Om succes är false.
            else
            {
                //Felmedellande som sedan laddar om metoden.
                Console.WriteLine("Inte ett korrekt svar, skriv ett tal över 0.");
                Console.ReadLine();
                Console.Clear();
                //Kallar metoden igen.
                StartMenu();
            }

        }
    }
}
