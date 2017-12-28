using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Mammalia
    {
        public Mammalia() { }

        public bool HasNeoCortex { get; set; }
        public int NumOfEarBones { get; set; }
        public bool IsWarmBlooded { get; set; }

        public string Nurse() => "Mammals nurse their young with milk.";
        public string GiveBirth() => "Mammals give birth to live young.";
        public string Communicate() => "Mammals can communicate a variety of ways.";
    }
}
