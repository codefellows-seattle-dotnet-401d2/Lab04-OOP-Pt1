using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Snake : Reptile
    {
        public override string Food { get; set; } = "meat";

        public override int Legs { get; set; } = 0;

        public override string Name { get; set; } = "Danger Noodle";

        public override string Goes { get; set; } = "ssssssss <=====8>-<";
    }
}
