
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures
{
    class Astronaut
    {
        //Public property
        public Location Location { get; set; }
        
        // Expression Bodied Property (always readonly)
        public bool SuitedUp => Name != "Space Person";
        
        // Read-Only Property
        public string Name { get; }

        // Public property with a private setter
        public string Job { get; private set; }
        
        public int OxygenLevel { private get; set; }

        public Astronaut(string name, string job)
        {
            Name = name;
            Job = job;
        }

        public void Promote()
        {
            Job = "Commander of Janitors";
        }

        public void DoYourJob()
        {
            Console.WriteLine($"{Name} is doing all their {Job} duties...");
        }


    }
}
