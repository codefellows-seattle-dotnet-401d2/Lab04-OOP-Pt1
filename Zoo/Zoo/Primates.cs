using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Primates : Mammalia
    {
        public bool PropertyOne { get; set; }
        public bool PropertyTwo { get; set; }
        public bool PropertyThree { get; set; }

        public string UseBinocularVision() => "Primates have forward facing eyes allowing accurate distance perception.";
        public string UsePowerGrip() => "Opposable thumbs allow primates to have a strong hold on things.";
        public string ThirdMethod() => "Primate method call 3.";
    }
}
