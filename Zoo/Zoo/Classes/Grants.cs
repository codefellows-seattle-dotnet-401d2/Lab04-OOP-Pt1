using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Grants : Zebra
    {
        public bool Mountain { get; set; }

        public bool Plain { get; set; }

        public int NumberOfZebras { get; set; }

        public void MoreSounds()
        {
            Console.WriteLine("Yipyip");
        }

        public void MoreEats()
        {
            Console.WriteLine("Grants Zebra eats locally grown organic vegetables");
        }

        public void Drink()
        {
            Console.WriteLine("Grants Zebra drinks cold pressed juice");
        }
    }
}
