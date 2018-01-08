using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract public class Animal
    {
        public void BornMsg()
        {
            Console.WriteLine(Name + " was born into the world!");
        }

        public void Eat()
        {
            Console.WriteLine(Name + " munches on some " + Food);
        }

        public void Call()
        {
            Console.WriteLine(Goes);
        }

        abstract public string Name { get; set; }

        public virtual int Legs { get; set; } = 4;

        abstract public string Food { get; set; }

        abstract public string Goes { get; set; }

        abstract public string SkinTexture { get; set; }

        abstract public bool LaysEggs { get; set; }

        abstract public bool WarmBlood { get; set; }
    }
}
