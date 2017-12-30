using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Canidae : Carnivora
    {
        public new string Diet { get; set; } = "Mostly Meat";
        public bool IsAlphaMale { get; set; }
        public int PackSize { get; set; }

        public override string Communicate()
        {
            return "Dog-like howl or bark.";
        }

        public override string Sleep()
        {
            return "Going to sleep.";
        }

        public override string Travel()
        {
            return "Travelling in a pack.";
        }
    }
}
