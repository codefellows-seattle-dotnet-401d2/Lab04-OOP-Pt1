using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Animal
    {
        public bool Alive;
        public Animal()
        {
            Alive = true;
        }

        public void IsAlive()
        {
            Console.WriteLine("It's alive!");
            Alive = true;
        }

        public void IsDead()
        {
            Console.WriteLine("It's dead!");
            Alive = false;
        }
    }
}
