using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Dog : Animal
    {
        bool hasFourLegs = true;

        public void Bark()
        {
            Console.WriteLine("Bark!");
        }
    }
}
