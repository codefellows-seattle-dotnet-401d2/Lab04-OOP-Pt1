using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Bird : Animal
    {
        public bool canFly;

        public void Birds()
        {
            canFly = true;
        }

        public void BirdCall(string sound) {
            Console.WriteLine($"This bird's call is {sound}!");
        }
    }
}
