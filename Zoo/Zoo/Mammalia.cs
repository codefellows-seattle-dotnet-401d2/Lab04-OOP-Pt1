using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Mammalia
    {
        public Mammalia() { }

        public bool HasNeoCortex { get; set; } = true;
        public int NumOfEarBones { get; set; } = 3;
        public bool IsWarmBlooded { get; set; } = true;

        public string Nurse() => "Mammals nurse their young with milk.";
        public string GiveBirth() => "Mammals give birth to live young.";
        public abstract string Communicate();
        public abstract string Travel();
    }
}
