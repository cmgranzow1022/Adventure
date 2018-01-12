using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Adventure
    {
        Beach beach = new Beach();
        Forest forest = new Forest();
        Desert desert = new Desert();
        Weather weather = new Weather();

        string weatherForecast;
        //member variables
        string userInput;
        //ctor
        public Adventure()
        {
          
        }

        //member methods

        public void chooseEnvironment()
        {
            Console.WriteLine("Enter a number between 1 and 3 to determine your destination");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    beach.beachMenu();
                    break;
                case "2":
                    forest.forestMenu();
                    break;
                case "3":
                    desert.desertMenu();
                    break;
            }
        }

        public void chooseEnding()
        {
            Console.WriteLine("How does it end? Enter 1,2 or 3.");
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("A helicopter spots you, picks you up and brings you home.");
                    break;
                case "2":
                    Console.WriteLine("You woke up from your dream and decided to never travel again.");
                    break;
                case "3":
                    Console.WriteLine("You came to the realization that you would be stranded alone forever.");
                    Console.WriteLine("You wished you would have brought a volleyball so you could have a Wilson like Tom Hanks did in Castaway");
                    Console.WriteLine("...But you didn't, so you died alone.");
                        break;
            }
        }

    }
}
