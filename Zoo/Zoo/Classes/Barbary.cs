using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Barbary : Lion
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
            Console.WriteLine("Barbary Lion eats chickens!");
        }

        public void Drink()
        {
            Console.WriteLine("Barbary Lion drinks blood!");
        }

        public Barbary()
        {
            MoreEats();
            Drink();
            MoreSounds();
        }
    }
}
