using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Player
    {
        //member variables
        string supplyItem;
        //ctor

        //member methods

        public void chooseSupplies()
        {
            Console.WriteLine("When you signed up for this mystery adventure, you agreed to only take one item.");
            Console.WriteLine("Select a number between 1 and 6 to determine what item you get to take.");
            supplyItem = Console.ReadLine();
        
            switch (supplyItem)
            {
                case "1":
                    Console.WriteLine("You get a roll of duct tape.");
                break;
                case "2":
                    Console.WriteLine("You get to take a large box of matches.");
                    break;
                case "3":
                    Console.WriteLine("For some reason, you choose to bring a box of doughnuts.");
                    break;
                case "4":
                    Console.WriteLine("You get a bottle of sunscreen.");
                    break;
                case "5":
                    Console.WriteLine("You get to take a blanket.");
                    break;
                case "6":
                    Console.WriteLine("You get to take 100 feet of rope.");
                    break;

            }
        }

        //public void startingLocation()
        //{
        //    Console.WriteLine("");
        //    userInput = Console.ReadLine();

        //    Console.WriteLine("");
        //}
    }
}
