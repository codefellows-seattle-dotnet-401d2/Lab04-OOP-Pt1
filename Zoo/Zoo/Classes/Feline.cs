using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Feline : Mammal
    {
        public override string Food { get; set; } = "meat";
        public override string Goes { get; set; } = "Roooowr";
    }
}
