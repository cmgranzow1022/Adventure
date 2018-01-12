using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Weather
    {
        //member variables
        string userInput;
        int weatherInput;
        //ctor

        //member methods
        public void weatherForecast()
        {
            Random rnd = new Random();
            weatherInput = rnd.Next(1,5);

            switch (weatherInput)
            {
                case 1:
                    Console.WriteLine("Today is sunny.");
                    break;
                case 2:
                    Console.WriteLine("Looks like storms are rolling in.");
                    break;
                case 3:
                    Console.WriteLine("test3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                    }

        }

    }
}
