using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Zebra : Mammals
    {
        public bool Stripes { get; set; }

        public bool NarrowMane { get; set; }

        public bool Hooves { get; set; }

        public void Sound()
        {
          Console.WriteLine("Zebra can bark or yip");

        }

        public void Eat()
        {
            Console.WriteLine("Zebras are vegans!");
        }

        public static string Location()
        {
           return "Zebras live in Africa!";   
        }
    }
}
