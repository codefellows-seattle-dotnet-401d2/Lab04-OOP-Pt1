using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class WestAfrican : Lion
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
            Console.WriteLine("West African Lion eats chickens!");
        }

        public void Drink()
        {
            Console.WriteLine("West African Lion drinks blood!");
        }

        public static string CheckLion()
        {
            return Location();
        }

        public WestAfrican()
        {
            MoreSounds();
            MoreEats();
            Drink();
        }
    }
}
