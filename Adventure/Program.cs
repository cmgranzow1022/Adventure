﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Adventure newAdventure = new Adventure();
            Player player = new Player();
            player.chooseSupplies();
            newAdventure.chooseEnvironment();
            newAdventure.chooseEnding();
            Console.ReadLine();
        }
    }
}
