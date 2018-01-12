using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Beach
    {
        //member variables

        string envtWeather; 
        string userInput;
        //constructor

        //member methods

        public void beachMenu()
        {
            Console.WriteLine("You're adventure has led you to an uninhabited beach somewhere in the Caribbean.");
            Console.WriteLine(envtWeather);
            Console.WriteLine("Choose a number between 1 and 4 to find out what happens next!");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("You find a box with scuba gear buried under a palm tree.");
                    Console.WriteLine("The oxygen tank happens to be nearly full.");
                    Console.WriteLine("You are exploring the coral reef when suddenly a huge shark starts swimming toward you");
                    sharkBait();
                    break;
                case "2":
                    Console.WriteLine("You were looking forward to a beach vacation in your future anyways.");
                    Console.WriteLine("You find a nice spot to relax next to a tall palm tree and start to doze off.");
                    Console.WriteLine("When you wake up, you realize that you are no longer the only one on the beach.");
                    Console.WriteLine("While you were sleeping, the beach was invaded by Pirates.");
                    pirateShip();
                    break;
            }
        }








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
                 
                    break;
                case "2":
                    Console.WriteLine("Unfortunately for you, this shark hasn't eaten in over a week.");
                    Console.WriteLine("You try to punch it in the nose but that only makes it more irritated.");
                    Console.WriteLine("It bites down on your leg.");
                    break;
            }
        }


        public void pirateShip()
        {
            Console.WriteLine("Choose a number between 1 and 3 to find out what happens next.");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("They take you prisoner on their ship.");
                    Console.WriteLine("You try to convince the crew you could live the Pirate life, but they don't budge.");
                    Console.WriteLine("They make you walk the plank");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("They think you're pretty neat.");
                    Console.WriteLine("They bring all the rum from their ship onto the beach and you party together til the sun comes up.");
                    Console.ReadLine();
                    break;
            }
        }


       

    }
}
