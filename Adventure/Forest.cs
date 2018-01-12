using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Forest
    {
        //member variables
        
        string userInput;
        //constructor

        //member methods
        public void sasquatchDinner()
        {
            Console.WriteLine("Choose a number between 1 and 3");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("Turns out he wanted to eat you FOR dinner.");
                    Console.WriteLine("The end.");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                case "2":
                    Console.WriteLine("Sasquatch and the rest of his family cook a rabbit stew.");
                    Console.WriteLine("You have great conversation, and they send you on your way with leftovers.");
                    Console.WriteLine("You are thankful for the warm meal, and promise not to tell anyone where they live.");
                    break;

            }
        }


        public void bearSnuggles()
        {
            Console.WriteLine("Choose 1 or 2 to find out what happens next.");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("You determine that you would rather be warm and just stay there.");
                    Console.WriteLine("Besides, it's sort of romantic to be snuggled up with someone (or something) under the stars.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("The bear starts snoring so you think its in deep enough sleep to make an escape.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    break;
            }
        }


        public void forestMenu()
        {
            Console.WriteLine("An old school bus with blacked out windows dropped you off in the middle of a dense forest.");
            Console.WriteLine("The weather looks ******");
            Console.WriteLine("Choose 1 or 2 to find out what happens next!");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("You begin exploring when you hear twigs snapping nearby.");
                    Console.WriteLine("You can't believe your eyes, but Sasquatch himself walks out from behind a tree.");
                    Console.WriteLine("Through a bit of a language barrier, he invites you over for dinner.");
                    sasquatchDinner();
                    break;
                case "2":
                    Console.WriteLine("You start to build a shelter as the sun is about to set.");
                    Console.WriteLine("You get a small fire started by rubbing two sticks together, and begin to doze off .");
                    Console.WriteLine("When you wake up, you notice that the fire has gone out, but you are unusually warm.");
                    Console.WriteLine("The warmth is coming from the giant brown bear that has decided to snuggle with you.");
                    bearSnuggles();
                    break;
            }
        }

    }






}

