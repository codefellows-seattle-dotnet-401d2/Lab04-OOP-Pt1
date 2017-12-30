using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Primates : Mammalia
    {
        public bool CanClimbTrees { get; set; } = true;
        public bool CanWalkOnTwoLegs { get; set; } = true;
        public bool HasIntelligence { get; set; } = true;

        public string UseBinocularVision() => "Primates have forward facing eyes allowing accurate distance perception.";
        public string UsePowerGrip() => "Opposable thumbs allow primates to have a strong hold on things.";
        public abstract string UseTools();
    }
}
