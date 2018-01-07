using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammals : ZooClass
    {
        public bool HairAndFur { get; set; }

        public bool WarmBlooded { get; set; }

        public bool Diaphrams { get; set; }

        public void Walk()
        {
            Console.WriteLine("Mammals can walk");
        }
        
        public void Talk()
        {
            Console.WriteLine("Mammals can talk!");
        }

        public void Chew()
        {
            Console.WriteLine("Mammals can chew!");
        }

    }
}
