using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Cape : Zebra
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
            Console.WriteLine("Cape Zebra eats locally grown organic vegetables");
        }

        public void Drink()
        {
            Console.WriteLine("Cape Zebra drinks cold pressed juice");
        }

        public static string CheckZebra()
        {
            return Location();
        }
    }
}
