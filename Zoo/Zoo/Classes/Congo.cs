using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Congo : Lion
    {
        public bool CriticallyEndangdered { get; set; }

        public int NumberOfLions { get; set; }

        public bool ShorterMane { get; set; }

        public void MoreSounds()
        {
            Console.WriteLine("Roar!!!");
        }

        public void MoreEats()
        {
            Console.WriteLine("Congo Lion eats chickens!");
        }

        public void Drink()
        {
            Console.WriteLine("Congo Lion drinks blood!");
        }
    }
}
