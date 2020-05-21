using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, 0, "Townsquare",
                "This is the fountain of the town",
                "/Engine;component/Images/Locations/TownSquare.png");
            newWorld.AddLocation(0, 1, "Herbalit's Hut",
                "This is where alchemy happens",
                "/Engine;component/Images/Locations/HerbalistsHut.png");
            newWorld.AddLocation(0, 2, "Herb Garden",
                "Come to herb your potion items",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");
            newWorld.AddLocation(0, -1, "home",
                "Herbalist Garden", 
                "/Engine;component/Images/Locations/Home.png");
            newWorld.AddLocation(-2, -1, "Farmer's Field",
                "You can see the corns from far away",
                "/Engine;component/Images/Locations/FarmFields.png");          
            newWorld.AddLocation(-1, -1, "Farmer's House",
                 "Farmers House",
                 "/Engine;component/Images/Locations/FarmFields.png");
            newWorld.AddLocation(-1, 0, "Trading Shop",
                 "Come and trade your goodies",
                 "/Engine;component/Images/Locations/Trader.png");
            newWorld.AddLocation(1, 0, "Town Gate",
                 "This is the Town gate",
                 "/Engine;component/Images/Locations/TownGate.png"); 
            newWorld.AddLocation(2, 0, "Spider Forrest",
                  "Giagant Spider",
                  "/Engine;component/Images/Locations/SpiderForrest.png");





            return newWorld;
        }
    }
}
