using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Grevy : Zebra
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
            Console.WriteLine("Grevy Zebra eats locally grown organic vegetables");
        }

        public void Drink()
        {
            Console.WriteLine("Grevy Zebra drinks cold pressed juice");
        }
       // return Zebra.Sound();
    }
    //return Zebra.Sound();
}
