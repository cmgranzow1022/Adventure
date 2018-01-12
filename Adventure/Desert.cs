using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Desert
    {

        //member variables
        string userInput;
        //constructor

        //member methods
        public void rattleSnakes()
        {
            Console.WriteLine("Choose what you would like to do:");
            Console.WriteLine("   1. Stand your ground");
            Console.WriteLine("   2. Run away");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("Somehow, you manage to successful wrestle all of the rattlesnakes and tie them into knots, unscatched.");
                    Console.WriteLine("");
                    break;
                case "2":
                    Console.WriteLine("Poor choice, these suckers move fast.");
                    Console.WriteLine("They all catch up to you and you sustain several bites.");
                    Console.WriteLine("The venom kills you quickly.");
                    Console.WriteLine("The end");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You've entered an invalid choice. Please try again.");
                    rattleSnakes();
                    break;

            }
        }


        public void cactusSpines()
        {

            Console.WriteLine("Choose what you would like to do:");
            Console.WriteLine("   1. Get water out of cactus");
            Console.WriteLine("   2. Pull spines out to relieve pain");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("Even though you are in pain, you realize there is probably some water inside the cactus.");
                    Console.WriteLine("You tap into the perfect spot and are able to rehydrate.");
                    Console.WriteLine("You decide to take a nap before you start traveling again, and lay your head on a deathstalker scorpion.");
                    Console.WriteLine("The venom kills you.");
                    Console.WriteLine("The end.");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("You pull out all of the spines, which takes over an hour.");
                    Console.WriteLine("The combination of dehydration and infected wounds ultimately kills you.");
                    Console.WriteLine("The end.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("You've entered an invalid choice. Please try again.");
                    cactusSpines();
                    break;

            }
        }


        public void desertMenu()
        {
            Console.WriteLine("An airplane has dropped you off in the middle of the Sahara Desert.");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("   1. Explore");
            Console.WriteLine("   2. Find water");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("You start walking and happen upon a family of rattlesnakes.");
                    Console.WriteLine("They all start to shake their rattles vigorously and the first one advances quickly towards you.");

                    
                    break;
                case "2":
                    Console.WriteLine("You realize quickly that you are becoming dehyrated and there is no water in sight.");
                    Console.WriteLine("Days go by and you still haven't found a good water source.");
                    Console.WriteLine("You see a person in the distance and slowly make your way towards them. You pass out right before you reach them.");
                    Console.WriteLine("When you come to, your body is full of cactus spines -- you gave the cactus a hug after mistaking it for another person.");
                    cactusSpines();
                    break;
                default:
                    Console.WriteLine("You've entered an invalid choice. Please try again.");
                    desertMenu();
                    break;

            }
        }

    }
}

