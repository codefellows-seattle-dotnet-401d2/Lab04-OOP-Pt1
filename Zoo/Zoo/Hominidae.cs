using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Hominidae : Primates
    {
        public bool HasTail { get; set; } = false;
        public bool IsPregnant { get; set; }
        public bool IsHungry { get; set; }

        public override string Communicate() => "Hominidae can use speech or sign language to communicate.";

        public override string UseTools() => "Hominidae can fashion advanced tools to assist with tasks.";

        public override string Travel() => "Hominidae can climb up trees, but usually travel by ground.";
    }
}
