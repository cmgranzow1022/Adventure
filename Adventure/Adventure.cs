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
            Console.WriteLine("Does your adventure have a happy ending? Choose 1 or 2 to find out.");
            userInput = Console.ReadLine();
            switch (userInput)
            {

                case "0":
                    Environment.Exit(0);
                    break;
                     case "1":
                    Console.WriteLine("A helicopter spots you, picks you up and brings you home. You live happily ever after.");
                    break;
                case "2":
                    Console.WriteLine("You woke up from your dream and decided to never travel again.");
                    break;
                default:
                    Console.WriteLine("You enetered an invalid number. Please try again.");
                    chooseEnding();
                    break;
            }
        }

    }
}
