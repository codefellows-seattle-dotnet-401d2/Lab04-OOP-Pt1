using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Gecko : Lizard
    {
        public override string Food { get; set; } = "bugs";

        public override string Name { get; set; } = "Geiko";

        public override string Goes { get; set; } = "Blimey";
    }
}
