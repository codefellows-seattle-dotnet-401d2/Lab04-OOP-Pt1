using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Carnivora : Mammalia
    {
        public string Diet { get; set; } = "Usually meat.";
        public bool Bipedal { get; set; } = false;
        public int Weight { get; set; }

        public string Hunt() => "Carnivora hunts with teeth and claws.";
        public string Eat() => "Lets eat some meat!";
        public abstract string Sleep();
    }
}
