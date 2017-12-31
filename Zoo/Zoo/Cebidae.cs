using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Cebidae : Primates
    {
        public bool IsSleepy { get; set; }
        //read a fun fact about a study where capuchin monkeys were taught how to use money as a medium of exchange.
        public bool KnowsConceptOfMoney { get; set; }
        public int NumOfFriends { get; set; }

        public override string Communicate()
        {
            return "Cebidae communicate with sounds and gestures.";
        }

        public override string Travel()
        {
            return "Cebidae almost exclusively travel by trees.";
        }

        public override string UseTools()
        {
            return "Cebidae are capable of using simple tools to accomplish tasks.";
        }
    }
}
