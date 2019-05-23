using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Lion : Mammals
    {
        public bool Mane { get; set; }

        public bool Paws { get; set; }

        public bool LargeEyes { get; set; }

        public void Sound()
        {
            Console.WriteLine("Roar!!!");
        }

        public void Eat()
        {
            Console.WriteLine("Lions eat other animals!");
        }

        public static string Location()
        {
            return "Lions live in Africa south of the Sahara Desert";
        }
    }
}
