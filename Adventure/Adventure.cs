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
        
        //member variables

        //ctor

        //member methods
        public void chooseEnvironment()
        {
            Console.WriteLine("Enter a number between 1 and 4 to determine your destination");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                beach.beachMenu();
                    break;
                case "2":


            }
            
        }
    }
}
