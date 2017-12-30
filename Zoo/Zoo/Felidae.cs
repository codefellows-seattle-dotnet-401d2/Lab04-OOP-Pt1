using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Felidae : Carnivora
    {
        public new string Diet { get; set; } = "Entirely meat";
        public string Personality { get; set; } = "Loner";
        public string HuntingPreference { get; set; }

        public override string Communicate()
        {
            return "Cat-like roar or meow";
        }

        public override string Sleep()
        {
            return "Lets take a cat nap";
        }

        public override string Travel()
        {
            return "Travelling alone";
        }
    }
}
