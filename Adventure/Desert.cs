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
        public void sharkBait()
        {
            Console.WriteLine("Choose a number between 1 and 3");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("You punch the shark in the nose as hard as you can.");
                    Console.WriteLine("It swims away in defeat and you head back to the beach.");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Unfortunately for you, this shark hasn't eaten in over a week.");
                    Console.WriteLine("You try to punch it in the nose but that only makes it more irritated.");
                    Console.WriteLine("It bites down on your leg.");
                    Console.ReadLine();
                    break;

            }
        }


        public void cactusSpines()
        {
            Console.WriteLine("Choose a number between 1 and 3 to find out what happens next.");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("Even though you are in pain, you realize there is probably some water inside the cactus.");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("They think you're pretty neat.");
                    Console.WriteLine("They bring all the rum from their ship onto the beach and you party together til the sun comes up.");
                    Console.ReadLine();
                    break;
            }
        }


        public void desertMenu()
        {
            Console.WriteLine("An airplane has dropped you off in the middle of the Sahara Desert.");
            Console.WriteLine("The weather is ");
            Console.WriteLine("Choose a number between 1 and 4 to find out what happens next!");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("You start walking and happen upon a family of rattlesnakes.");
                    Console.WriteLine("They all start to shake their rattles vigorously and the first one advances quickly towards you.");
                    Console.WriteLine("Somehow, you manage to successful wrestle all of the rattlesnakes and tie them into knots, unscatched.");
                    sharkBait();
                    break;
                case "2":
                    Console.WriteLine("You realize quickly that you are becoming dehyrated and there is no water in sight.");
                    Console.WriteLine("Days go by and you still haven't found a good water source.");
                    Console.WriteLine("You see a person in the distance and slowly make your way towards them. You pass out right before you reach them.");
                    Console.WriteLine("When you come to, your body is full of cactus spines -- you gave the cactus a hug after mistaking it for another person.");
                    cactusSpines();
                    break;
            }
        }

    }
}

