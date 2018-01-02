using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Reptile : Animal
    {
        public bool coldblooded;

        public Reptile()
        {
            coldblooded = true;
        }

        public void Hiss() {
            Console.WriteLine($"This animal hisses at you!");
        }
    }
}
