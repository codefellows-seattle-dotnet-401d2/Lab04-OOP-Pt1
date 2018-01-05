using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Chameleon : Lizard
    {
        public override string Food { get; set; } = "bugs";

        public override string Name { get; set; } = "Larry the Hidden";

        public override string Goes { get; set; } = "...";
    }
}
